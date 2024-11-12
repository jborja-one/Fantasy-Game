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

        public bool CanPerform(Character character)
        {
            //Cooldown check
            if (LastUsed.HasValue && (DateTime.Now - LastUsed.Value).TotalSeconds < Cooldown)
            {
                Console.WriteLine($"{Name} is on cooldown.");
            }

            //Job check
            if (character.Job.Name != "Black Mage" || character.Job.Name != "WhiteMage")
            {
                Console.WriteLine($"{character.Job.Name} cannot use {Name}. Only Magic users can use this Ability.");
                return false;
            }

            //level check
            if (character.Level < RequiredLevel)
            {
                Console.WriteLine($"{character.Name} does not mee the required level to cast {Name}");
                return false;
            }

            return true;
        }

        public bool Execute(Character character, IAction action)
        {
            if(!CanPerform(character))
            {
                return false;
            }

            if(action is ISpell spell)
            {
                int originalCastTime = spell.CastTime;
                spell.CastTime = 0;
                spell.Execute(character);
                spell.CastTime = originalCastTime;
                LastUsed = DateTime.Now;
                return true;
            }
            return false;
        }
    }
}

