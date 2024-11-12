using Core.Models;
using Core.Interfaces;
using Core.Actions.OffensiveSpells;
using Core.Actions.CasterAbilities;

namespace Core.Jobs
{
	public class BlackMage : Job
	{
		public BlackMage(string name, string description) : base(name, description)
		{
			Name = "Black Mage";
			Description = "In days long past, there existed an occult and arcane art known as black magic—a potent magic of pure destructive force born forth by a sorceress of unparalleled power.";
			Spells = new List<ISpell>
			{
                new Fire()
			};
			Abilities = new List<IAbility>
			{
				new SwiftCast()
			};
		}
	}
}
	

