using ItemChanger.Locations;
using ItemChanger.Silksong.Containers;
using ItemChanger.Silksong.Tags;
using ItemChanger.Tags;

namespace ItemChanger.Silksong.RawData;

// Scene + object data sourced from SceneCapture.json and cross-referenced with
// Br3zzly/silksong-completionist relic categories.
//
// Skipped (shop purchases — handled via ShopLocation):
//   Psalm_Cylinder__Choir_Voices    (Librarian NPC)
//   Psalm_Cylinder__Salvation_Theme (Grindle shop)
//
// Skipped (quest / NPC rewards — need non-ObjectLocation mechanism):
//   Rune_Harp__Burden  (Conductor NPC reward)
//   Rune_Harp__Escape  (Sprint Challenge reward)
//

internal static partial class BaseLocationList
{
    // ── Psalm Cylinders ───────────────────────────────────────────────────────

    // Hang_10: confirmed via SceneCapture
    public static Location Psalm_Cylinder__Ascendence_Theme => new ObjectLocation
    {
        Name = LocationNames.Psalm_Cylinder__Ascendence_Theme,
        SceneName = "Hang_10",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Library_09: two pickups — "Collectable Item Pickup" (y≈12) is the psalm cylinder,
    // "Collectable Item Pickup (1)" (y≈36) is a rosary necklace.
    public static Location Psalm_Cylinder__Sermon => new ObjectLocation
    {
        Name = LocationNames.Psalm_Cylinder__Sermon,
        SceneName = "Library_09",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Under_08: two pickups — "Collectable Item Pickup" is the Memory Locket,
    // "Collectable Item Pickup (1)" is the psalm cylinder.
    public static Location Psalm_Cylinder__Surgery => new ObjectLocation
    {
        Name = LocationNames.Psalm_Cylinder__Surgery,
        SceneName = "Under_08",
        ObjectName = "Collectable Item Pickup (1)",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // ── Rune Harps ────────────────────────────────────────────────────────────

    // Weave_08: confirmed via SceneCapture
    public static Location Rune_Harp__Eva => new ObjectLocation
    {
        Name = LocationNames.Rune_Harp__Eva,
        SceneName = "Weave_08",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // ── Sacred Cylinder ───────────────────────────────────────────────────────

    // Library_08: confirmed via SceneCapture ("Collectable Item Pickup Librarian")
    public static Location Sacred_Cylinder => new ObjectLocation
    {
        Name = LocationNames.Sacred_Cylinder,
        SceneName = "Library_08",
        ObjectName = "Collectable Item Pickup Librarian",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // ── Weaver Effigies ───────────────────────────────────────────────────────

    // Slab_12: confirmed by user
    public static Location Weaver_Effigy__Atla => new ObjectLocation
    {
        Name = LocationNames.Weaver_Effigy__Atla,
        SceneName = "Slab_12",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Bonetown: confirmed via SceneCapture
    public static Location Weaver_Effigy__Camora => new ObjectLocation
    {
        Name = LocationNames.Weaver_Effigy__Camora,
        SceneName = "Bonetown",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Shellwood_25: confirmed by user
    public static Location Weaver_Effigy__Keelal => new ObjectLocation
    {
        Name = LocationNames.Weaver_Effigy__Keelal,
        SceneName = "Shellwood_25",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };
}
