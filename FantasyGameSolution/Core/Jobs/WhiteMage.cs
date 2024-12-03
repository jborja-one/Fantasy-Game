using System;
using Core.Models;
using Core.Actions.DefensiveSpells;
using Core.Interfaces;using Core.Actions.CasterAbilities;using Core.Actions.OffensiveSpells;namespace Core.Jobs
{
	public class WhiteMage : Job
	{
		public WhiteMage() { }        public override void Initialize()        {
			JobId = 7;
			Name = "White Mage";
			Description = "White magic, the arcane art of succor, was conceived eras past that the world might know comfort. Alas, man began perverting its powers for self-gain, and by his wickedness brought about the Sixth Umbral catastrophe.";
			Spells = new List<ISpell>
			{
				new Stone(),
				new Cure(),
				new Aero(),
				new CureII(),
				new StoneII(),
				new AeroII(),
				new Glare(),
				new Holy()
			};
			Abilities = new List<IAbility>			{
				new SwiftCast(),
				new Regen()
			};
		}
	}
}

