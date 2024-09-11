using ProofOfConcepts.TheWheelOfWarcraft.Enums;

namespace ProofOfConcepts.TheWheelOfWarcraft.Models.Classes;

public class Priest : WoWClass
{
    public Priest()
    {
        Name = WoWClasses.Priest;
        ClassColor = WoWClassColors.Priest;
        WoWSpecializations =
        [
            new WoWSpecialization("Discipline", WoWClassRoles.Healer),
            new WoWSpecialization("Holy", WoWClassRoles.Healer),
            new WoWSpecialization("Shadow", WoWClassRoles.Damage)
        ];
    }
}
