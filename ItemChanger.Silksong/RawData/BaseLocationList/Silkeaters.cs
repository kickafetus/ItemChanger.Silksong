using ItemChanger.Locations;
using ItemChanger.Silksong.Containers;

namespace ItemChanger.Silksong.RawData;

// Scene + object data sourced from Br3zzly/silksong-completionist (silkeaters.ts)
// and confirmed via SceneCapture.json ("Silk Grub Large Cocoon" object name verified in Song_24).
// All silkeater cocoons are SilkGrubCocoon objects — handled via BreakableContainerLocation.
internal static partial class BaseLocationList
{
    public static Location Silkeater__Bilewater => new BreakableContainerLocation
    {
        Name = LocationNames.Silkeater__Bilewater,
        SceneName = "Organ_01",
        ObjectName = "Silk Grub Large Cocoon",
    };

    public static Location Silkeater__Blasted_Steps => new BreakableContainerLocation
    {
        Name = LocationNames.Silkeater__Blasted_Steps,
        SceneName = "Coral_37",
        ObjectName = "Silk Grub Large Cocoon",
    };

    public static Location Silkeater__Choral_Chambers_East => new BreakableContainerLocation
    {
        Name = LocationNames.Silkeater__Choral_Chambers_East,
        SceneName = "Song_09b",
        ObjectName = "Silk Grub Large Cocoon",
    };

    public static Location Silkeater__Choral_Chambers_West => new BreakableContainerLocation
    {
        Name = LocationNames.Silkeater__Choral_Chambers_West,
        SceneName = "Song_24",
        ObjectName = "Silk Grub Large Cocoon",
    };

    public static Location Silkeater__Deep_Docks => new BreakableContainerLocation
    {
        Name = LocationNames.Silkeater__Deep_Docks,
        SceneName = "Dock_14",
        ObjectName = "Silk Grub Large Cocoon",
    };

    public static Location Silkeater__Greymoor => new BreakableContainerLocation
    {
        Name = LocationNames.Silkeater__Greymoor,
        SceneName = "Greymoor_04",
        ObjectName = "Silk Grub Large Cocoon",
    };

    public static Location Silkeater__The_Cradle => new BreakableContainerLocation
    {
        Name = LocationNames.Silkeater__The_Cradle,
        SceneName = "Tube_Hub",
        ObjectName = "Silk Grub Large Cocoon",
    };

    public static Location Silkeater__Whiteward => new BreakableContainerLocation
    {
        Name = LocationNames.Silkeater__Whiteward,
        SceneName = "Ward_04",
        ObjectName = "Silk Grub Large Cocoon",
    };

    public static Location Silkeater__Whispering_Vaults => new BreakableContainerLocation
    {
        Name = LocationNames.Silkeater__Whispering_Vaults,
        SceneName = "Library_14",
        ObjectName = "Silk Grub Large Cocoon",
    };
}
