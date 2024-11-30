using Core.Models;
using Core.Actions.RangedActions;
using Core.Interfaces;

namespace Core.Jobs
{
	public class Bard : Job
	{
		public Bard() { }        public override void Initialize()        {
			JobId = 1;
			Name = "Bard";
			Description = "The word \"bard\" ordinarily puts folk in mind of those itinerant minstrels, fair of voice and nimble of finger, who earn their coin performing in taverns and the halls of great lords. Few know, however, that bards in fact trace their origins back to the bowmen of eld, who sang in the heat of battle to fortify the spirits of their companions.";
			Actions = new List<IAction>
			{
				new HeavyShot()
			};
		}
	}
}

