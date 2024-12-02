using Core.Models;
using Core.Interfaces;

namespace Core.Actions.CasterAbilities
{
	public class SwiftCast : IAbility
	{
		public string Name { get; set; } = "Swiftcast";
		public string Description { get; set; } = "Next spell is cast immediately";
		public int Cooldown { get; set; } = 60;
        public string Effect { get; set; } = "Next spell is cast immediately";
		public int RequiredLevel { get; set; } = 15;
		public DateTime? LastUsed { get; set; }
		public int EffectDuration { get; set; } = 10;        
    }
}

