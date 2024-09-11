using ProofOfConcepts.TheWheelOfWarcraft.Enums;

namespace ProofOfConcepts.TheWheelOfWarcraft.Models.Classes;

public class Hunter : WoWClass
{
    public Hunter()
    {
        Name = WoWClasses.Hunter;
        ClassColor = WoWClassColors.Hunter;
        WoWSpecializations =
        [
            new WoWSpecialization("Beast Mastery", WoWClassRoles.Damage),
            new WoWSpecialization("Marksmanship", WoWClassRoles.Damage),
            new WoWSpecialization("Survival", WoWClassRoles.Damage)
        ];        
    }
}
