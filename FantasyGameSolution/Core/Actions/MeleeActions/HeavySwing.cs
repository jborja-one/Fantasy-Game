using Core.Models;
using Core.Interfaces;

namespace Core.Actions.MeleeActions
{
	public class HeavySwing : IAction
	{
		public string Name { get; set; } = "Heavy Swing";
		public string Description { get; set; } = "Delivers an Attack with a Potency of 15";
		public int Cooldown { get; set; } = 2;		
		public int Potency { get; set; } = 15;
		public int RequiredLevel { get; set; } = 1;
		public DateTime? LastUsed { get; set; }       
    }
}

