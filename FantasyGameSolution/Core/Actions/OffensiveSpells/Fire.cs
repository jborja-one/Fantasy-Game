using Core.Models;
using Core.Interfaces;

namespace Core.Actions.OffensiveSpells
{
	public class Fire : ISpell
	{
		public string Name { get; set; } = "Fire";
		public string Description { get; set; } = "Deals 20 in fire damage";
		public int Cooldown { get; set; } = 3;
		public int CastTime { get; set; } = 3;
		public int ManaCost { get; set; } = 10;
		public int Potency { get; set; } = 20;
		public int RequiredLevel { get; set; } = 1;
		public DateTime? LastUsed { get; set; }


		public bool CanPerform(Character character)
		{
			//Cooldown check
			if(LastUsed.HasValue && (DateTime.Now - LastUsed.Value).TotalSeconds < Cooldown)
			{
				Console.WriteLine($"{Name} is on cooldown.");
			}

			//Job check
			if(character.Job.Name != "Black Mage")
			{
				Console.WriteLine($"{character.Job.Name} cannot use {Name}. Only Black Mages can cast this spell.");
				return false;
			}

			//level check
			if(character.Level < RequiredLevel)
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
				target.Health -= Potency;
				return target.AttackTarget(target);						
			}
			else
			{
				Console.WriteLine($"{Name} cannot be cast on {target.Name}.");
				return 0;
			}
		}
	}
}

