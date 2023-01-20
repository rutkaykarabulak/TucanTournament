using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TucanTournament.Utils;
namespace TucanTournament.Services
{
	/// <summary>
	/// This service is used to create Players and doing some operation on them.
	/// </summary>
	public class PlayerService
	{
		/// <summary>
		/// Calculates the total score of basketball players.
		/// </summary>
		/// <param name="points"></param>
		/// <param name="rebounds"></param>
		/// <param name="assits"></param>
		/// <returns>Total score of player</returns>
		public static int CalculateBasketballPlayerPoints(
			Types.PlayerPosition position,
			int scores,
			int rebounds,
			int assists)
		{
			switch(position)
			{
				case Types.PlayerPosition.Guard:
					return (scores * 2) + (rebounds * 3) + (assists * 1);
				case Types.PlayerPosition.Forward:
					return (scores * 2) + (rebounds * 2) + (assists * 2);
				case Types.PlayerPosition.Center:
					return (scores * 2) + (rebounds * 1) + (assists * 3);
				default:
					return 0;
			}
		}

		/// <summary>
		/// Calculates the total score of handball players.
		/// </summary>
		/// <param name="position"></param>
		/// <param name="goalsMade"></param>
		/// <param name="goalsReceived"></param>
		/// <returns></returns>
		public static int CalculateHandballPlayerPoints(
			Types.PlayerPosition position,
			int goalsMade,
			int goalsReceived)
		{
			switch (position)
			{
				case Types.PlayerPosition.Goalkeeper:
					return (Constants.InitialRatingPointGoalkeeper)
						+ (goalsMade * 5) + (goalsReceived * -2);
				case Types.PlayerPosition.FieldPlayer:
					return (Constants.InitialRatingPointFieldPlayer)
						+ (goalsMade * 1) + (goalsReceived * -1);
				default:
					return 0;
			} 
		}

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
	}
}
