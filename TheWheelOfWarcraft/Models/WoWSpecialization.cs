namespace ProofOfConcepts.TheWheelOfWarcraft.Models;

public class WoWSpecialization
{
    public string SpecializationName { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;

    public WoWSpecialization(string specializationName, string role)
    {
        SpecializationName = specializationName;
        Role = role;
    }
}
