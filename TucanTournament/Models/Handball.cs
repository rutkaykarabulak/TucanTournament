using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TucanTournament.Utils;

namespace TucanTournament.Models
{
	/// <summary>
	/// Handball is type of sport.
	/// </summary>
	public class Handball:Sport
	{
		/// <summary>
		/// Parameterized constructor
		/// </summary>
		public Handball(
			string name,
			string federation,
			int id)
		{
			Name =	name;
			Type = Utils.Types.SportType.Handball;
			Federation = federation;
			Id = id;
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
	}
}
