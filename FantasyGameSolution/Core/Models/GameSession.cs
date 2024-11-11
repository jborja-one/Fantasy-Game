using System;
namespace Core.Models
{
	public class GameSession
	{
		public string SessionId { get; set; }
		public List<Player> Players { get; set; }
		public DateTime StartTime { get; set; }
		public string Status { get; set; }

		public GameSession(string sessionId)
		{
			SessionId = sessionId;
			Players = new List<Player>();
			StartTime = DateTime.Now;
			Status = "Active";
		}
	}
}

