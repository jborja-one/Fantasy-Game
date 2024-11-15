﻿using Core.Interfaces;

namespace Core.Models
{
    public abstract class Job
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<IAbility> Abilities { get; set; }
        public List<IAction> Actions { get; set; }
        public List<ISpell> Spells { get; set; }

        public Job(string name, string description)
        {
            Name = name;
            Description = description;
            Abilities = new List<IAbility>();
            Actions = new List<IAction>();
            Spells = new List<ISpell>();
        }

        //TODO is this needed?
        //public void AddAbility(IAction ability)
        //{
        //    Abilities.Add(ability);
        //}

        //public void AddAction(IAction action)
        //{
        //    Actions.Add(action);
        //}

        //TODO Perform action here?
        //public void PerformAction(IAction action, Character target)
        //{
        //    if (action.CanPerform(this, Character character)) //defined in each specific job
        //    {
        //        action.Execute(target);
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{Name} cannot perform {action.Name}");
        //    }
        //}
    }
}

