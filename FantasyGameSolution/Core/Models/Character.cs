using System;
using Core.Interfaces;
namespace Core.Models
{
	public class Character
	{
		public int CharacterId { get; set; }
		public string Name { get; set; }
		public int Health { get; set; }
		public int Attack { get; set; }
		public int Defense { get; set; }
		public int Mana { set; get; }
		public int Level { get; set; }		
		public int JobId { get; set; }		public int PlayerId { get; set; }		public Character() { }

		public Character(int characterId, string name, int health, int attack, int defense, int jobId)
		{
			CharacterId = characterId;
			Name = name;
			Health = health;
			Attack = attack;
            Defense = defense;		
			JobId = jobId;
			Level = 1;
			Mana = Mana;			
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

