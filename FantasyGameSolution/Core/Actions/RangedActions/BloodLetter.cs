﻿using System;using Core.Interfaces;using Core.Models;namespace Core.Actions.RangedActions{    public class BloodLetter : IAction    {        public string Name { get; set; } = "Bloodletter";        public string Description { get; set; } = "Delivers an attack with a potency of 45";        public int Cooldown { get; set; } = 15;        public int Potency { get; set; } = 45;        public int RequiredLevel { get; set; } = 12;        public DateTime? LastUsed { get; set; }        public bool CanPerform(Character character)        {            //Cooldown check            if (LastUsed.HasValue && (DateTime.Now - LastUsed.Value).TotalSeconds < Cooldown)            {                Console.WriteLine($"{Name} is on cooldown.");            }            ////Job check            //if (character.Job.Name != "Bard")            //{            //    Console.WriteLine($"{character.Job.Name} cannot use {Name}. Only Bards can use this Action.");            //    return false;            //}            //level check            if (character.Level < RequiredLevel)            {                Console.WriteLine($"{character.Name} does not mee the required level to cast {Name}");                return false;            }            return true;        }        public int Execute(Character target)        {            if (CanPerform(target))            {                target.Health -= Potency;                return target.AttackTarget(target);            }            else            {                Console.WriteLine($"{Name} cannot be cast on {target.Name}.");                return 0;            }        }    }}