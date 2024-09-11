using ProofOfConcepts.TheWheelOfWarcraft.Enums;

namespace ProofOfConcepts.TheWheelOfWarcraft.Models.Classes;

public class Mage : WoWClass
{
    public Mage()
    {
        Name = WoWClasses.Mage;
        ClassColor = WoWClassColors.Mage;
        WoWSpecializations =
        [
            new WoWSpecialization("Arcane", WoWClassRoles.Damage),
            new WoWSpecialization("Fire", WoWClassRoles.Damage),
            new WoWSpecialization("Frost", WoWClassRoles.Damage)
        ];        
    }
}
