using ProofOfConcepts.TheWheelOfWarcraft.Enums;

namespace ProofOfConcepts.TheWheelOfWarcraft.Models.Classes;

public class DeathKnight : WoWClass
{
    public DeathKnight()
    {
        Name = WoWClasses.DeathKnight;
        ClassColor = WoWClassColors.DeathKnight;
        WoWSpecializations = 
        [
            new WoWSpecialization("Blood", WoWClassRoles.Tank),
            new WoWSpecialization("Frost", WoWClassRoles.Damage),
            new WoWSpecialization("Unholy", WoWClassRoles.Damage)
        ];
    }
}
