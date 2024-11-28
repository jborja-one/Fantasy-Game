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

        public Job(int jobId, string name, string description)
        {
            JobId = jobId;
            Name = name;
            Description = description;
            Abilities = new List<IAbility>();
            Actions = new List<IAction>();
            Spells = new List<ISpell>();
        }
    }
}

