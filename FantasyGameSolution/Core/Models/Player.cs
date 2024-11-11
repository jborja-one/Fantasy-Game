using System;
namespace Core.Models
{
	public class Player
	{
		public string PlayerId { get; set; }
		public string Name { get; set; }	
		public Job Job { get; set; }
		public string Status { get; set; }

		public Player(string playerId, string name, Job job)
		{
			PlayerId = playerId;
			Name = name;
			Job = job;			
			Status = "Active";
		}
	}
}

