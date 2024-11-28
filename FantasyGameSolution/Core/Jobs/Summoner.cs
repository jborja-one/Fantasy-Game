using Core.Models;
using Core.Interfaces;
using Core.Actions.CasterAbilities;

namespace Core.Jobs
{
	public class Summoner : Job
	{
		public Summoner(int jobId, string name, string description) : base(jobId, name, description)
		{
			JobId = 5;
			Name = "Summoner";
			Description = "The beast tribes of Eorzea worship and summon forth beings known as primals, among which, are Ifrit, Garuda, and Titan. Yet, what is a God to one man is a demon to another, for the city-states of Eorzea see these beings as a grave threat to their collective survival.";
			Abilities = new List<IAbility>
			{
				new SwiftCast()
			};
        }
	}
}

