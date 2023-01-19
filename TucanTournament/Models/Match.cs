using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TucanTournament.Models
{
	/// <summary>
	/// Match is being played between two teams and many other players.
	/// Players belong to the different teams such as team A and team B.
	/// </summary>
	public class Match
	{
		#region Constructor
		/// <summary>
		/// Parameterized constructor.
		/// </summary>
		public Match(Team opponentOne,
			Team opponentTwo,
			Team winner,
			Player mvp,
			DateTime date
			)
		{
			OpponentOne = opponentOne;
			OpponentTwo = opponentTwo;
			Winner = winner;
			MVP = mvp;
			DateOfTheMatch = date;
		}
		#endregion
		#region Properties
		/// <summary>
		/// First team of the match.
		/// </summary>
		public Team OpponentOne { get; set; }
		/// <summary>
		/// Second team of the match.
		/// </summary>
		public Team OpponentTwo { get; set; }

		/// <summary>
		/// Winner of the match.
		/// </summary>
		public Team Winner { get; set; }

		/// <summary>
		/// MVP of the match.
		/// </summary>
		public Player MVP { get; set; }

		/// <summary>
		/// Date of the match.
		/// </summary>
		public DateTime DateOfTheMatch { get; set; }
		#endregion

	}
}
