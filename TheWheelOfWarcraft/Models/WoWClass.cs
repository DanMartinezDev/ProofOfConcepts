using System;
using TheWheelOfWarcraft.Enums;

namespace TheWheelOfWarcraft.Models;

public class WoWClass
{
    public string Name = WoWClasses.Default;
    public string ClassColor = WoWClassColors.Default;
    public List<WoWSpecialization> WoWSpecializations = [];
}
