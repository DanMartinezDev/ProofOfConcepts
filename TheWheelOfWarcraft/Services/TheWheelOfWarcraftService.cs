using ProofOfConcepts.TheWheelOfWarcraft.Models;
using ProofOfConcepts.TheWheelOfWarcraft.Models.Classes;

namespace ProofOfConcepts.TheWheelOfWarcraft.Services;

public interface ITheWheelOfWarcraftService
{
    List<WoWClass> GetAllWoWClasses();
}

public class TheWheelOfWarcraftService : ITheWheelOfWarcraftService
{
    public List<WoWClass> GetAllWoWClasses() => [
            new DeathKnight(),
            new DemonHunter(),
            new Druid(),
            new Evoker(),
            new Hunter(),
            new Mage(),
            new Monk(),
            new Paladin(),
            new Priest(),
            new Rogue(),
            new Shaman(),
            new Warlock(),
            new Warrior()
        ];
}