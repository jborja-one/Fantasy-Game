using System;
using Core.Models;
using Core.Interfaces;
using Core.Actions.PhysicalAbilities;
using Core.Actions.MeleeActions;using Core.Actions.OffensiveSpells;using Core.Actions.DefensiveSpells;namespace Core.Jobs
{
	public class Paladin : Job
	{
		public Paladin() { }
		public override void Initialize()
		{
			JobId = 4;
			Name = "Paladin";
			Description = "For centuries, the elite of the Sultansworn have served as personal bodyguards to the royal family of Ul'dah. Known as paladins, these men and women marry exquisite swordplay with stalwart shieldwork to create a style of combat uncompromising in its defense.";
			Actions = new List<IAction>			{
				new FastBlade(),
				new RiotBlade(),
				new ShieldBash(),
				new GoringBlade(),
				new RoyalAuthority(),
				new BladeOfTruth(),
				new BladeOfValor(),
				new BladeOfFaith()
			};
			Abilities = new List<IAbility>			{
				new Rampart()
			};
			Spells = new List<ISpell>			{
				new HolySpirit(),
				new Clemency()
			};
		}	
	}
}

