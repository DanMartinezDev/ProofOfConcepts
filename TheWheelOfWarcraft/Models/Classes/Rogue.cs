using ProofOfConcepts.TheWheelOfWarcraft.Enums;

namespace ProofOfConcepts.TheWheelOfWarcraft.Models.Classes;

public class Rogue : WoWClass
{
    public Rogue()
    {
        Name = WoWClasses.Rogue;
        ClassColor = WoWClassColors.Rogue;
        WoWSpecializations =
        [
            new WoWSpecialization("Assassination", WoWClassRoles.Damage),
            new WoWSpecialization("Outlaw", WoWClassRoles.Damage),
            new WoWSpecialization("Subtlety", WoWClassRoles.Damage)
        ];
    }
}
