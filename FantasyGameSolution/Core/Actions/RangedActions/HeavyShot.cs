using Core.Models;
using Core.Interfaces;

namespace Core.Actions.RangedActions
{
	public class HeavyShot : IAction
	{
		public string Name { get; set; } = "Heavy Shot";
		public string Description { get; set; } = "Delivers an attack with a potency of 15";
		public int Cooldown { get; set; } = 2;
		public int Potency { get; set; } = 15;
		public int RequiredLevel { get; set; } = 1;
		public DateTime? LastUsed { get; set; }        
    }
}

