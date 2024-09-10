﻿using TheWheelOfWarcraft.Enums;

namespace TheWheelOfWarcraft.Models.Classes;

public class DemonHunter : WoWClass
{
    public DemonHunter()
    {
        Name = WoWClasses.DemonHunter;
        ClassColor = WoWClassColors.DemonHunter;
        WoWSpecializations = 
        [
            new WoWSpecialization("Vengeance", WoWClassRoles.Tank),
            new WoWSpecialization("Havoc", WoWClassRoles.Damage)
        ];
    }
}
