using Core.Models;
using Core.Interfaces;
using Core.Actions.CasterAbilities;
using Core.Actions.OffensiveSpells;using Core.Actions.DefensiveSpells;namespace Core.Jobs
{
	public class Summoner : Job
	{
		public Summoner() { }        public override void Initialize()        {
			JobId = 5;
			Name = "Summoner";
			Description = "The beast tribes of Eorzea worship and summon forth beings known as primals, among which, are Ifrit, Garuda, and Titan. Yet, what is a God to one man is a demon to another, for the city-states of Eorzea see these beings as a grave threat to their collective survival.";
			Spells = new List<ISpell>			{
				new Ruin(),
				new Carbuncle(),
				new EnergyDrain(),
				new Physic(),
				new Ifrit(),
				new Shiva(),
				new Fester(),
				new Painflare(),
				new Phoenix(),
				new Bahamut()
			};
			Abilities = new List<IAbility>
			{
				new SwiftCast()
			};
        }
	}
}

