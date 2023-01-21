using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using TucanTournament.Utils;

namespace TucanTournament.Models
{
	/// <summary>
	/// Team is a candidate of a match.
	/// Team consists of players.
	/// </summary>
	public class Team
	{

		#region Constructors
		/// <summary>
		/// Parameterized constructor 1.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="branch"></param>
		public Team(string name,
			Utils.Types.SportType branch)
		{
			Name = name;
			Branch = branch;
			Point = 0;
			Players = new List<Player>();
		}
		#endregion

		#region Properties
		/// <summary>
		/// Name of the team.
		/// </summary>
		public string Name { get; set; } = "";

		/// <summary>
		/// What kind of branch does this team perform?
		/// </summary>
		public Utils.Types.SportType Branch { get; set; }

		/// <summary>
		/// Players of the team.
		/// </summary>
		public List<Player> Players { get; set; }

		/// <summary>
		/// How many point does this team have?
		/// </summary>
		public int Point { get; set; }
		#endregion

		#region Functions 
		/// <summary>
		/// Adds 10 points to the each player.
		/// </summary>
		public void AddBonusWinnerPoint()
		{
			Players.ForEach(p => p.Score += Utils.Constants.BonusPoint);
		}
		#endregion
	}
}
