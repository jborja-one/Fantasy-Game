using System;
namespace Core.Models
{
	public class Player
	{
		public int PlayerId { get; set; }
		public string Name { get; set; }	
		public int CharacterId { get; set; }
		public string Status { get; set; }

		public Player () { }

		public Player(int playerId, string name, int characterId)
		{
			PlayerId = playerId;
			Name = name;				
			Status = "Active";
			CharacterId = characterId;
		}
	}
}

