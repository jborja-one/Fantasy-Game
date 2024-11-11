using System;
using Core.Models;

namespace Core.Jobs
{
	public class Summoner : Job
	{
		public Summoner(string name, string description) : base(name, description)
		{
			Name = "Summoner";
			Description = "The beast tribes of Eorzea worship and summon forth beings known as primals, among which, are Ifrit, Garuda, and Titan. Yet, what is a God to one man is a demon to another, for the city-states of Eorzea see these beings as a grave threat to their collective survival.";

        }
	}
}

