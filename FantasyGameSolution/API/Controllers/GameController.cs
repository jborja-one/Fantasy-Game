using Microsoft.AspNetCore.Mvc;
using Engine;
using Core.Models;


namespace API.Controllers
{
	[ApiController]
	[Route("api/game")]
	public class GameController : ControllerBase
	{
		private readonly GameSessionService _gameSessionService;

		public GameController(GameSessionService gameSessionService)
		{
			_gameSessionService = gameSessionService;
		}

		//POST api/game/start
		[HttpPost("start")]
		public IActionResult StartGame()
		{
			var sessionId = _gameSessionService.StartNewSession();
			return Ok(new { SessionId = sessionId, Message = "Game session started." });
		}

		//GET api/game/{sesisonId}
		[HttpGet("{sesisonId}")]
		public IActionResult GetGameSession(string sessionId)
		{
			var session = _gameSessionService.GetSession(sessionId);
			if (session == null)
				return NotFound(new { Message = "Game session not found" });

			return Ok(session);
		}

		//POST api/game/{sessionId}/addPlayer
		[HttpPost("{sessionId}/addPlayer")]
		public IActionResult AddPlayerToSession(string sessionId, [FromBody] Player player)
		{
			var session = _gameSessionService.GetSession(sessionId);
			if (session == null)
				return NotFound(new { Message = "Game session not found" });

			bool playerAdded = _gameSessionService.AddPlayerToSession(sessionId, player);
			if (!playerAdded)
				return BadRequest(new { Message = "Failed to add player. Session might be full" });

			return Ok(new { Message = $"Player {player.Name} added to the session." });

		}

		//POST api/game/{sessionId}/end
		[HttpPost("{sessionId}/end")]
		public IActionResult EndGameSession(string sessionId)
		{
			var result = _gameSessionService.EndSession(sessionId);
			if (!result)
				return NotFound(new { Message = "Game session not found" });

			return Ok(new { Message = "Game session ended." });
		}

	}
}

