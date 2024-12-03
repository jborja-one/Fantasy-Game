using Core.Models;
using Core.Interfaces;

namespace Core.Actions.DefensiveSpells
{
	public class Cure : ISpell
    {
		public string Name { get; set; } = "Cure";
		public string Description { get; set; } = "Heals player with a potency of 50";
		public int Cooldown { get; set; } = 3;
        public int CastTime { get; set; } = 2;
		public int ManaCost { get; set; } = 10;
		public int Potency { get; set; } = 50;
		public int RequiredLevel { get; set; } = 3;
		public DateTime? LastUsed { get; set; }       
    }
}

