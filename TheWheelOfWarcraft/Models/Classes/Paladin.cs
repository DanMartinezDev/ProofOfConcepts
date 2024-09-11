using ProofOfConcepts.TheWheelOfWarcraft.Enums;

namespace ProofOfConcepts.TheWheelOfWarcraft.Models.Classes;

public class Paladin : WoWClass
{
    public Paladin()
    {
        Name = WoWClasses.Paladin;
        ClassColor = WoWClassColors.Paladin;
        WoWSpecializations =
        [
            new WoWSpecialization("Holy", WoWClassRoles.Healer),
            new WoWSpecialization("Protection", WoWClassRoles.Tank),
            new WoWSpecialization("Retribution", WoWClassRoles.Damage)
        ];        
    }
}
