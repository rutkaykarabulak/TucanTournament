﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		/// Adds a player to the team.
		/// </summary>
		/// <param name="player"></param>
		public void AddPlayer (Player player) { 
			Players.Add(player);
		} 

		/// <summary>
		/// Adds 3 points to the team.
		/// </summary>
		public void AddPoint ()
		{
			Point += 3;
		}
		#endregion
	}
}