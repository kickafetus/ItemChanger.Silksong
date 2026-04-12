using ItemChanger.Locations;
using ItemChanger.Silksong.Containers;
using ItemChanger.Tags;

namespace ItemChanger.Silksong.RawData;

// Scene + object data sourced from Br3zzly/silksong-completionist (memoryLockets.ts).
// ObjectName is "Collectable Item Pickup" unless noted otherwise.
// Shop lockets (Mort, Frey/Bellhart) and quest locket (Flintbeetles) are handled separately.
internal static partial class BaseLocationList
{
    public static Location Memory_Locket__Hunters_March => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Hunters_March,
        SceneName = "Ant_20",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    public static Location Memory_Locket__Greymoor_Sewer => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Greymoor_Sewer,
        SceneName = "Greymoor_16",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Inside Halfway Home — requires Faydown Cloak
    public static Location Memory_Locket__Greymoor_HH => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Greymoor_HH,
        SceneName = "Halfway_01",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Bellhart: Silk Soar into the roof (Act 3)
    public static Location Memory_Locket__Bellhart_BellhomeCiel => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Bellhart_BellhomeCiel,
        SceneName = "Belltown",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // The Marrow: top area, requires Cling Grip
    public static Location Memory_Locket__The_Marrow => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__The_Marrow,
        SceneName = "Bone_18",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Choral Chambers: Grand Bellway, behind breakable wall above Bellway
    public static Location Memory_Locket__Coral_Chambers => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Coral_Chambers,
        SceneName = "Bellway_City",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Wormways: held by a corpse at bottom-right
    public static Location Memory_Locket__Wormways => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Wormways,
        SceneName = "Crawl_09",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Blasted Steps: narrow platform above sands — uses "Collectable Item Pickup (1)"
    public static Location Memory_Locket__Blasted_Steps => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Blasted_Steps,
        SceneName = "Coral_02",
        ObjectName = "Collectable Item Pickup (1)",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Underworks: hidden area left of confession booth
    public static Location Memory_Locket__Underworks_Confessional => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Underworks_Confessional,
        SceneName = "Under_08",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    public static Location Memory_Locket__Whispering_Vaults => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Whispering_Vaults,
        SceneName = "Library_08",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Bilewater: far-left edge of secret room, west bench approach
    public static Location Memory_Locket__Bilewater_Hidden_Room_West_Bench => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Bilewater_Hidden_Room_West_Bench,
        SceneName = "Shadow_20",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Bilewater: corpse in breakable cocoon dangling from ceiling.
    public static Location Memory_Locket__Bilewater_Cocoon_Corpse => new BreakableContainerLocation
    {
        Name = LocationNames.Memory_Locket__Bilewater_Cocoon_Corpse,
        SceneName = "Shadow_27",
        ObjectName = "Breakable Hang Sack Memory Locket",
    };

    // Deep Docks: corpse at bottom of magma-filled area behind breakable wall
    public static Location Memory_Locket__Deep_Docks => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Deep_Docks,
        SceneName = "Dock_13",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // The Slab: inside shortcut cave, behind breakable wall
    public static Location Memory_Locket__The_Slab => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__The_Slab,
        SceneName = "Slab_Cell_Quiet",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    public static Location Memory_Locket__Memorium => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Memorium,
        SceneName = "Arborium_05",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Far Fields: secret area near Karmelita cave — Act 3
    public static Location Memory_Locket__Far_Fields_Secret => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Far_Fields_Secret,
        SceneName = "Bone_East_25",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };

    // Sands of Karak: corpse at the top of the area
    public static Location Memory_Locket__Sands_of_Karak => new ObjectLocation
    {
        Name = LocationNames.Memory_Locket__Sands_of_Karak,
        SceneName = "Coral_23",
        ObjectName = "Collectable Item Pickup",
        Correction = default,
        Tags = [new OriginalContainerTag { ContainerType = ContainerNames.Shiny }]
    };
}
