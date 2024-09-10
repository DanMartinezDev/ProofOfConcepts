using TheWheelOfWarcraft.Enums;

namespace TheWheelOfWarcraft.Models.Classes;

public class Druid : WoWClass
{
    public Druid()
    {
        Name = WoWClasses.Druid;
        ClassColor = WoWClassColors.Druid;
        WoWSpecializations = 
        [
            new WoWSpecialization("Guardian", WoWClassRoles.Tank),
            new WoWSpecialization("Restoration", WoWClassRoles.Healer),
            new WoWSpecialization("Feral", WoWClassRoles.Damage),
            new WoWSpecialization("Balance", WoWClassRoles.Damage)
        ];
    }
}
