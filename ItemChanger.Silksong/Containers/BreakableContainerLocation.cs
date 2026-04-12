using HarmonyLib;
using ItemChanger.Containers;
using ItemChanger.Enums;
using ItemChanger.Extensions;
using ItemChanger.Locations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ItemChanger.Silksong.Containers;

/// <summary>
/// Location for items held inside a breakable container. Supports two container types,
/// detected automatically from the named object when the scene loads:
/// <list type="bullet">
/// <item><description>
///   <see cref="SilkGrubCocoon"/> — silkeater cocoons. Detected via a Harmony postfix on
///   <see cref="SilkGrubCocoon.WasHit"/>. The vanilla silk-grub drop is suppressed on the
///   final hit and replaced with the IC shiny.
/// </description></item>
/// <item><description>
///   <see cref="PersistentBoolItem"/> — jars, sacks, and other generic breakables. An IC
///   shiny is pre-created at the object's position and revealed the frame the container breaks.
/// </description></item>
/// </list>
/// </summary>
public class BreakableContainerLocation : AutoLocation
{
    /// <summary>
    /// Name of the breakable container GameObject (or a child of it) used to locate it in the scene.
    /// </summary>
    public required string ObjectName { get; init; }

    // ── SilkGrubCocoon support ─────────────────────────────────────────────────

    private static readonly Dictionary<string, List<BreakableContainerLocation>> _cocoonRegistry = new();
    private static Harmony? _harmony;

    // ── Lifecycle ──────────────────────────────────────────────────────────────

    protected override void DoLoad()
    {
        ItemChangerHost.Singleton.GameEvents.AddSceneEdit(SceneName!, OnSceneLoaded);
    }

    protected override void DoUnload()
    {
        ItemChangerHost.Singleton.GameEvents.RemoveSceneEdit(SceneName!, OnSceneLoaded);

        if (_cocoonRegistry.TryGetValue(SceneName!, out List<BreakableContainerLocation>? list))
        {
            list.Remove(this);
            if (list.Count == 0) _cocoonRegistry.Remove(SceneName!);
        }

        if (_cocoonRegistry.Count == 0 && _harmony != null)
        {
            _harmony.UnpatchSelf();
            _harmony = null;
        }
    }

    private void OnSceneLoaded(Scene scene)
    {
        GameObject? obj = scene.FindGameObjectByName(ObjectName);
        if (obj == null) return;

        // ── SilkGrubCocoon path ────────────────────────────────────────────────
        SilkGrubCocoon? cocoon = obj.GetComponent<SilkGrubCocoon>();
        if (cocoon != null)
        {
            if (!_cocoonRegistry.TryGetValue(scene.name, out List<BreakableContainerLocation>? list))
                _cocoonRegistry[scene.name] = list = [];
            if (!list.Contains(this)) list.Add(this);

            if (_harmony == null)
            {
                _harmony = new Harmony("ItemChanger.Silksong.BreakableContainerLocation");
                _harmony.PatchAll(typeof(Patches));
            }
            return;
        }

        // ── PersistentBoolItem path ────────────────────────────────────────────
        PersistentBoolItem? persistentBool = obj.GetComponentInParent<PersistentBoolItem>();
        if (persistentBool == null) return;

        Vector3 spawnPos = obj.transform.position;
        UObject.Destroy(obj);

        if (Placement!.AllObtained()) return;

        ContainerInfo info = ContainerInfo.FromPlacement(
            Placement!,
            scene,
            ContainerNames.Shiny,
            FlingType.DirectDeposit
        );

        GameObject shiny = ShinyContainer.Instance.GetNewContainer(info);
        ShinyContainer.Instance.ApplyTargetContext(shiny, spawnPos, Vector3.zero);
        shiny.SetActive(false);

        ContainerBreakWatcher watcher = persistentBool.gameObject.AddComponent<ContainerBreakWatcher>();
        watcher.Target = persistentBool;
        watcher.OnBroken = () => { if (shiny != null) shiny.SetActive(true); };
    }

    // ── Shared spawn ───────────────────────────────────────────────────────────

    private void SpawnShiny(Vector3 position, Scene scene)
    {
        if (Placement!.AllObtained()) return;

        ContainerInfo info = ContainerInfo.FromPlacement(
            Placement!,
            scene,
            ContainerNames.Shiny,
            FlingType.DirectDeposit
        );

        GameObject shiny = ShinyContainer.Instance.GetNewContainer(info);
        ShinyContainer.Instance.ApplyTargetContext(shiny, position, Vector3.zero);
    }

    // ── SilkGrubCocoon Harmony patches ────────────────────────────────────────

    [HarmonyPatch(typeof(SilkGrubCocoon), nameof(SilkGrubCocoon.WasHit))]
    private static class Patches
    {
        [HarmonyPrefix]
        private static void BeforeWasHit(SilkGrubCocoon __instance, out bool __state)
        {
            __state = __instance.gameObject.activeSelf;

            if (__state && FindLocation(__instance) != null)
            {
                int hitsLeft = Traverse.Create(__instance).Field<int>("hitsLeft").Value;
                if (hitsLeft <= 1)
                    Traverse.Create(__instance).Field<CollectableItem>("dropItem").Value = null!;
            }
        }

        [HarmonyPostfix]
        private static void AfterWasHit(SilkGrubCocoon __instance, bool __state)
        {
            if (!__state || __instance.gameObject.activeSelf) return;

            FindLocation(__instance)?.SpawnShiny(
                __instance.transform.position,
                __instance.gameObject.scene);
        }

        private static BreakableContainerLocation? FindLocation(SilkGrubCocoon cocoon)
        {
            if (!_cocoonRegistry.TryGetValue(cocoon.gameObject.scene.name, out List<BreakableContainerLocation>? locations))
                return null;
            foreach (BreakableContainerLocation loc in locations)
                if (cocoon.gameObject.name == loc.ObjectName) return loc;
            return null;
        }
    }

    // ── PersistentBoolItem watcher ─────────────────────────────────────────────

    private class ContainerBreakWatcher : MonoBehaviour
    {
        public PersistentBoolItem Target = null!;
        public System.Action OnBroken = null!;

        private void Update()
        {
            if (Target != null && Target.GetCurrentValue())
            {
                OnBroken?.Invoke();
                Destroy(this);
            }
        }
    }
}
