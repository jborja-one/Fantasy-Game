﻿using System;
using Core.Models;
using Core.Actions.DefensiveSpells;
using Core.Interfaces;namespace Core.Jobs
{
	public class WhiteMage : Job
	{
		public WhiteMage(int jobId, string name, string description) : base(jobId, name, description)
		{
			JobId = 6;
			Name = "White Mage";
			Description = "White magic, the arcane art of succor, was conceived eras past that the world might know comfort. Alas, man began perverting its powers for self-gain, and by his wickedness brought about the Sixth Umbral catastrophe.";
			Spells = new List<ISpell>
			{
				new Cure()
			};
		}
	}
}

