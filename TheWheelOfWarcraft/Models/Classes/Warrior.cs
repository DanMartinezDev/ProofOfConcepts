using TheWheelOfWarcraft.Enums;

namespace TheWheelOfWarcraft.Models.Classes;

public class Warrior : WoWClass
{
    public Warrior()
    {
        Name = WoWClasses.Warrior;
        ClassColor = WoWClassColors.Warrior;
        WoWSpecializations =
        [
            new WoWSpecialization("Protection", WoWClassRoles.Tank),
            new WoWSpecialization("Arms", WoWClassRoles.Damage),
            new WoWSpecialization("Fury", WoWClassRoles.Damage)
        ];        
    }
}
