using TheWheelOfWarcraft.Enums;

namespace TheWheelOfWarcraft.Models.Classes;

public class Monk : WoWClass
{
    public Monk()
    {
        Name = WoWClasses.Monk;
        ClassColor = WoWClassColors.Monk;
        WoWSpecializations =
        [
            new WoWSpecialization("Brewmaster", WoWClassRoles.Tank),
            new WoWSpecialization("Mistweaver", WoWClassRoles.Healer),
            new WoWSpecialization("Windwalker", WoWClassRoles.Damage)
        ];        
    }
}
