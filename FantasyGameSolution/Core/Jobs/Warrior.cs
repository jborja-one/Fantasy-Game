using System;
using Core.Models;
using Core.Actions.MeleeActions;

namespace Core.Jobs
{
	public class Warrior : Job
	{
		public Warrior(string name, string description) : base(name, description)
		{
			Name = "Warrior";
			Description = "On the northernmost edge of Abalathia's Spine exists a mountain tribe renowned for producing fearsome mercenaries. Wielding greataxes and known as warriors, these men and women learn to harness their inner-beasts and translate that power to unbridled savagery on the battlefield.";
			Actions = new List<IAction>
			{
				new HeavySwing()
			};
		}
	}
}

