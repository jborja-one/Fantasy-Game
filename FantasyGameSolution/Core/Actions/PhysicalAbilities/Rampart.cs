using Core.Models;
using Core.Interfaces;

namespace Core.Actions.PhysicalAbilities
{
	public class Rampart : IAbility
	{
		public string Name { get; set; } = "Rampart";
		public string Description { get; set; } = "Reduces damage taken by 20% for 20s.";
		public int Cooldown { get; set; } = 90;
		public string Effect { get; set; } = "Reduces damage taken by 20% for 20s.";
		public int RequiredLevel { get; set; } = 8;
		public DateTime? LastUsed { get; set; }
		public int EffectDuration { get; set; } = 20;       
    }
}

