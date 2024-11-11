using System;
namespace Core.Models
{
	public interface IAbility
	{
        string Name { get; set; }
        string Description { get; set; }
        int Cooldown { get; set; }                
        int RequiredLevel { get; set; }
        string Effect { get; set; }
        DateTime? LastUsed { get; set; }
        bool CanPerform(Character character);
        bool Execute(Character target, IAction action);
    }
}

