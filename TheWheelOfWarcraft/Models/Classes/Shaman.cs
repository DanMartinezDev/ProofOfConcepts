using ProofOfConcepts.TheWheelOfWarcraft.Enums;

namespace ProofOfConcepts.TheWheelOfWarcraft.Models.Classes;

public class Shaman : WoWClass
{
    public Shaman()
    {
        Name = WoWClasses.Shaman;
        ClassColor = WoWClassColors.Shaman;
        WoWSpecializations =
        [
            new WoWSpecialization("Restoration", WoWClassRoles.Healer),
            new WoWSpecialization("Elemental", WoWClassRoles.Damage),
            new WoWSpecialization("Enhancement", WoWClassRoles.Damage)
        ];
    }
}
