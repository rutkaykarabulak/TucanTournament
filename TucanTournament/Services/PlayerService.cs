using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TucanTournament.Models;
using TucanTournament.Utils;
using static TucanTournament.Utils.Types;

namespace TucanTournament.Services
{
	/// <summary>
	/// This service is used to create Players and doing some operation on them.
	/// </summary>
	public class PlayerService
	{
		/// <summary>
		/// Gets a position of player by char in given text file.
		/// </summary>
		/// <param name="branch"></param>
		/// <param name="position"></param>
		/// <returns>Default basketball player guard, otherwise any other position can be returned</returns>
		public static Types.PlayerPosition GetPlayerPositionByChar(Types.SportType branch, char position)
		{
			if (branch == Types.SportType.Basketball)
			{
				switch (position)
				{
					case 'G':
						return Types.PlayerPosition.Guard;
					case 'F':
						return Types.PlayerPosition.Forward;
					case 'C':
						return Types.PlayerPosition.Center;
					default:
						break;
				}
			} else if (branch == Types.SportType.Handball)
			{
				switch (position)
				{
					case 'G':
						return Types.PlayerPosition.Goalkeeper;
					case 'F':
						return Types.PlayerPosition.FieldPlayer;
					default:
						break;
				}
			}

			return Types.PlayerPosition.Guard;
		}

		/// <summary>
		/// Plays basketball games, adds players to the given teams.
		/// </summary>
		/// <param name="lines"></param>
		/// <param name="branch"></param>
		/// <param name="teamA"></param>
		/// <param name="teamB"></param>
		public static void PlayBasketballGame(List<string> lines, SportType branch,Team teamA, Team teamB)
		{
			foreach (string line in lines)
			{
				string[] parts = line.Split(';');

				string name = parts[Constants.PlayerNamePosition];
				int jersey = Int32.Parse(parts[Constants.PlayerJerseyPosition]);
				Team team = parts[Constants.PlayerTeamPosition] == "Team A" ? teamA : teamB;
				PlayerPosition position = PlayerService.GetPlayerPositionByChar(branch, parts[Constants.PlayerPosition].ToCharArray()[0]);
				int scores = Int32.Parse(parts[Constants.BasketballPlayerScorePosition]);
				int assists = Int32.Parse(parts[Constants.BasketballPlayerAssistPosition]);
				int rebounds = Int32.Parse(parts[Constants.BasketballPlayerReboundPosition]);
				int score = Basketball.CalculateBasketballPlayerPoints(position, scores, rebounds, assists);

				Player player = new(branch, name, jersey, team, score);

			}
		}

		public static void PlayHandballGame(List<string> lines, SportType branch, Team teamA, Team teamB)
		{
			foreach (string line in lines)
			{
				string[] parts = line.Split(';');

				string name = parts[Constants.PlayerNamePosition];
				int jersey = Int32.Parse(parts[Constants.PlayerJerseyPosition]);
				Team team = parts[Constants.PlayerTeamPosition] == "Team A" ? teamA : teamB;
				PlayerPosition position = PlayerService.GetPlayerPositionByChar(branch, parts[Constants.PlayerPosition].ToCharArray()[0]);
				int goalsMade = Int32.Parse(parts[Constants.HandballPlayerGoalsMadePosition]);
				int goalsReceived = Int32.Parse(parts[Constants.HandballPlayerGoalsReceivedPosition]);
				int score = Handball.CalculateHandballPlayerPoints(position, goalsMade, goalsReceived);

				Player player = new(branch, name, jersey, team, score);
			}
		}
	}
}
