using Core.Models;
using Core.Interfaces;

namespace Core.Actions.OffensiveSpells
{
	public class Fire : ISpell
	{
		public string Name { get; set; } = "Fire";
		public string Description { get; set; } = "Deals 50 potency in fire damage";
		public int Cooldown { get; set; } = 2;
		public int CastTime { get; set; } = 2;
		public int ManaCost { get; set; } = 10;
		public int Potency { get; set; } = 50;
		public int RequiredLevel { get; set; } = 1;
		public DateTime? LastUsed { get; set; }		
	}
}

