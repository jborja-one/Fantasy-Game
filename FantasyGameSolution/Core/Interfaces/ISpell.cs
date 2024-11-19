﻿using Core.Models;

namespace Core.Interfaces
{
    public interface ISpell
    {
        string Name { get; set; }
        string Description { get; set; }
        int Cooldown { get; set; }
        int CastTime { get; set; }
        int ManaCost { get; set; }
        int Potency { get; set; }
        int RequiredLevel { get; set; }
        DateTime? LastUsed { get; set; }
        bool CanPerform(Character character);
        int Execute(Character target);
    }
}