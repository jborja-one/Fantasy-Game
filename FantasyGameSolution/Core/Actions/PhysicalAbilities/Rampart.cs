using System;
using Core.Models;

namespace Core.Actions.PhysicalAbilities
{
	public class Rampart : IAbility
	{
		public string Name { get; set; } = "Rampart";
		public string Description { get; set; } = "Reduces damage taken by 20%";
		public int Cooldown { get; set; } = 90;
		public string Effect { get; set; } = "Reduces damage taken by 20%";
		public int RequiredLevel { get; set; } = 8;
		public DateTime? LastUsed { get; set; }
		public int EffectDuration { get; set; }

        public bool CanPerform(Character character)
        {
            //Cooldown check
            if (LastUsed.HasValue && (DateTime.Now - LastUsed.Value).TotalSeconds < Cooldown)
            {
                Console.WriteLine($"{Name} is on cooldown.");
            }

            //Job check
            if (character.Job.Name != "Warrior" || character.Job.Name != "Paladin")
            {
                Console.WriteLine($"{character.Job.Name} cannot use {Name}. Only Tanks can use this Ability.");
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

            int originalDefense = character.Defense;
            character.Defense = (int)(character.Defense * 0.2);
            

                return true;
        }
    }
}

