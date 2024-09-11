using ProofOfConcepts.TheWheelOfWarcraft.Enums;

namespace ProofOfConcepts.TheWheelOfWarcraft.Models.Classes;

public class Evoker : WoWClass
{
    public Evoker()
    {
        Name = WoWClasses.Evoker;
        ClassColor = WoWClassColors.Evoker;
        WoWSpecializations =
        [
            new WoWSpecialization("Preservation", WoWClassRoles.Healer),
            new WoWSpecialization("Devastion", WoWClassRoles.Damage),
            new WoWSpecialization("Augmentation", WoWClassRoles.Damage)
        ];        
    }
}
