using System;
using Core.Models;
using Core.Interfaces;
using Core.Actions.PhysicalAbilities;

namespace Core.Jobs
{
	public class Paladin : Job
	{
		public Paladin() { }
		public override void Initialize()
		{
			JobId = 4;
			Name = "Paladin";
			Description = "For centuries, the elite of the Sultansworn have served as personal bodyguards to the royal family of Ul'dah. Known as paladins, these men and women marry exquisite swordplay with stalwart shieldwork to create a style of combat uncompromising in its defense.";
			Abilities = new List<IAbility>			{
				new Rampart()
			};
		}	
	}
}

