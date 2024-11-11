using Core.Models;
using System.Collections.Generic;

namespace Engine
{
	public class GameSessionService
	{
		private readonly Dictionary<string, GameSession> _sessions = new();
		private const int MaxPlayersPerSession = 5;

		public string StartNewSession()
		{
			var sessionId = Guid.NewGuid().ToString();
			_sessions[sessionId] = new GameSession(sessionId);
			return sessionId;
		}

		public GameSession GetSession(string sessionId)
		{
			_sessions.TryGetValue(sessionId, out var session);
			return session;
		}

		public bool AddPlayerToSession(string sessionId, Player player)
		{
			if(_sessions.TryGetValue(sessionId, out var session))
			{
				if(session.Players.Count < MaxPlayersPerSession)
				{
					session.Players.Add(player);
					return true;
				}
			}
			return false;
		}

		public bool EndSession(string sessionId)
		{
			return _sessions.Remove(sessionId);
		}
	}
}

