using System;
namespace Core.Models
{
	public class Character
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int Attack { get; set; }
		public int Defense { get; set; }
		public int Mana { set; get; }
		public int Level { get; set; }
		public Job Job { get; set; }
		public List<IAction> Actions { get; set; }

		public Character(string name, int health, int attack, int defense, Job job)
		{
			Name = name;
			Health = health;
			Attack = attack;
            Defense = defense;
			Job = job;
			Level = 1;
			Mana = Mana;
			Actions = new List<IAction>();
		}

		public void TakeDamage(int damage)
		{
			Health -= Math.Max(damage - Defense, 0);
		}

		public int AttackTarget(Character target)
		{
			int damage = Math.Max(Attack - target.Defense, 0);
			target.TakeDamage(damage);
			Console.WriteLine($"{target} takes {damage} points of damage");
			return damage;
		}
	}
}

