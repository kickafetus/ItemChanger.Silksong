using Benchwarp.Data;
using ItemChanger.Silksong.RawData;

namespace ItemChangerTesting.LocationTests;

/// <summary>
/// Spawns near the Greymoor silkeater cocoon to verify that breaking any silkeater
/// spawns a falling IC shiny that can be picked up. All 8 silkeater locations are
/// replaced with Rosary Strings.
/// </summary>
internal class SilkeaterGreymoorTest : Test
{
    public override TestMetadata GetMetadata() => new()
    {
        Folder = TestFolder.LocationTests,
        MenuName = "Silkeater - All (Rosary String)",
        MenuDescription = "Spawns near Greymoor_04 with all abilities and maps. " +
                          "Replaces all silkeater cocoons with a Rosary String.",
        Revision = 2026041103,
    };

    public override void Setup(TestArgs args)
    {
        StartNear("Greymoor_04", PrimitiveGateNames.left1);

        string[] silkeaterLocations =
        [
            LocationNames.Silkeater__Bilewater,
            LocationNames.Silkeater__Blasted_Steps,
            LocationNames.Silkeater__Choral_Chambers_East,
            LocationNames.Silkeater__Choral_Chambers_West,
            LocationNames.Silkeater__Deep_Docks,
            LocationNames.Silkeater__Greymoor,
            LocationNames.Silkeater__The_Cradle,
            LocationNames.Silkeater__Whiteward,
            LocationNames.Silkeater__Whispering_Vaults,
        ];

        foreach (string locationName in silkeaterLocations)
        {
            Profile.AddPlacement(
                Finder.GetLocation(locationName)!
                      .Wrap()
                      .Add(Finder.GetItem(ItemNames.Rosary_String)!));
        }
    }

    protected override void OnEnterGame()
    {
        base.OnEnterGame();
        PlayerData.instance.hasDash = true;
        PlayerData.instance.hasWalljump = true;
        PlayerData.instance.hasDoubleJump = true;
        PlayerData.instance.hasBrolly = true;
        PlayerData.instance.mapAllRooms = true;
    }
}
