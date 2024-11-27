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
		public int ManaCost { get; set; } = 15;
		public int Potency { get; set; } = 50;
		public int RequiredLevel { get; set; } = 3;
		public DateTime? LastUsed { get; set; }

        public bool CanPerform(Character character)
        {
            //Cooldown check
            if (LastUsed.HasValue && (DateTime.Now - LastUsed.Value).TotalSeconds < Cooldown)
            {
                Console.WriteLine($"{Name} is on cooldown.");
            }

            //Job check
            if (character.Job.Name != "Black Mage")
            {
                Console.WriteLine($"{character.Job.Name} cannot use {Name}. Only White Mages can cast this spell.");
                return false;
            }

            //level check
            if (character.Level < RequiredLevel)
            {
                Console.WriteLine($"{character.Name} does not mee the required level to cast {Name}");
                return false;
            }

            character.Mana -= ManaCost;
            return true;
        }


        public int Execute (Character target)
        {
            if(CanPerform(target))
            {
                return target.Health += Potency;
            }
            else
            {
                Console.WriteLine($"{Name} cannot be cast on {target.Name}.");
                return 0;
            }
        }
    }
}

