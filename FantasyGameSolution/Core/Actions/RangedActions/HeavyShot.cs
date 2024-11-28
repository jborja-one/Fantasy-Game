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

        public bool CanPerform(Character character)
        {
            //Cooldown check
            if (LastUsed.HasValue && (DateTime.Now - LastUsed.Value).TotalSeconds < Cooldown)
            {
                Console.WriteLine($"{Name} is on cooldown.");
            }

            ////Job check
            //if (character.Job.Name != "Bard")
            //{
            //    Console.WriteLine($"{character.Job.Name} cannot use {Name}. Only Bards can use this Action.");
            //    return false;
            //}

            //level check
            if (character.Level < RequiredLevel)
            {
                Console.WriteLine($"{character.Name} does not mee the required level to cast {Name}");
                return false;
            } 

            return true;
        }

        public int Execute(Character target)
        {
            if (CanPerform(target))
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

