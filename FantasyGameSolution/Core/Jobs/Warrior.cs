using Core.Models;
using Core.Interfaces;
using Core.Actions.MeleeActions;
using Core.Actions.PhysicalAbilities;

namespace Core.Jobs
{
	public class Warrior : Job
	{
		public Warrior() { }        public override void Initialize()        
		{
			JobId = 6;
			Name = "Warrior";
			Description = "On the northernmost edge of Abalathia's Spine exists a mountain tribe renowned for producing fearsome mercenaries. Wielding greataxes and known as warriors, these men and women learn to harness their inner-beasts and translate that power to unbridled savagery on the battlefield.";
			Actions = new List<IAction>
			{
				new HeavySwing(),
				new Maim(),
				new Overpower(),
				new Tomahawk(),
				new SteelCyclone(),
				new InnerBeast(),
				new InnerChaos()
			};			Abilities = new List<IAbility>			{
				new Rampart(),
				new Berserk(),
				new Equilibrium()
			};
		}
	}
}

