using System;
using Core.Models;

namespace Core.Actions.CasterAbilities
{
	public interface ICasterAbility : IAction
	{
		int ManaCost { get; set; }
		void Cast(Character target);
	}
}

