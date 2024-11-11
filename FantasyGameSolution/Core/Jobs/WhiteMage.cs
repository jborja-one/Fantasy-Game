using System;
using Core.Models;

namespace Core.Jobs
{
	public class WhiteMage : Job
	{
		public WhiteMage(string name, string description) : base(name, description)
		{
			Name = "White Mage";
			Description = "White magic, the arcane art of succor, was conceived eras past that the world might know comfort. Alas, man began perverting its powers for self-gain, and by his wickedness brought about the Sixth Umbral catastrophe.";
		}
	}
}

