using ProofOfConcepts.TheWheelOfWarcraft.Enums;

namespace ProofOfConcepts.TheWheelOfWarcraft.Models.Classes;

public class Warlock : WoWClass
{
    public Warlock()
    {
        Name = WoWClasses.Warlock;
        ClassColor = WoWClassColors.Warlock;
        WoWSpecializations =
        [
            new WoWSpecialization("Affliction", WoWClassRoles.Damage),
            new WoWSpecialization("Demonology", WoWClassRoles.Damage),
            new WoWSpecialization("Destruction", WoWClassRoles.Damage)
        ];        
    }
}
