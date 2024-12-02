using Core.Interfaces;

namespace Core.Models
{
    public abstract class Job
    {
        public int JobId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<IAbility> Abilities { get; set; }
        public List<IAction> Actions { get; set; }
        public List<ISpell> Spells { get; set; }
        public abstract void Initialize();
    }
}

