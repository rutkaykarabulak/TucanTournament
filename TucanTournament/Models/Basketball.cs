using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TucanTournament.Utils;

namespace TucanTournament.Models
{
	/// <summary>
	/// Basketball is a type of sport.
	/// </summary>
	public class Basketball:Sport
	{
		/// <summary>
		/// Parameterized constructor
		/// </summary>
		public Basketball(string name,
			string federation,
			int id)
		{
			Name = name;
			Type = Utils.Types.SportType.Basketball;
			Federation = federation;	
			Id = id;	
		}

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
			switch (position)
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
	}
}
