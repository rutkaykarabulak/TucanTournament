using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TucanTournament.Utils;

namespace TucanTournament.Models
{
	/// <summary>
	/// Player is a person who performs the sport.
	/// </summary>
	public class Player
	{
		public Player(Types.SportType branch,
			string name,
			int jerseyNumber,
			Team team)
		{
			Branch = branch;
			Name = name;
			JerseyNumber = jerseyNumber;
			Team = team;
			AddPlayerToTeam(team);
		}
		#region Properties
		/// <summary>
		/// Which sport branch does player perform?
		/// </summary>
		public Utils.Types.SportType Branch { get; set; }

		/// <summary>
		/// Name of the player.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Number of the player.
		/// </summary>
		public int JerseyNumber { get; set; }

		/// <summary>
		/// Which team does this player play for?
		/// </summary>
		public Team Team { get; set; }

		/// <summary>
		/// Position of the player
		/// </summary>
		public Types.PlayerPosition Position { get; set; }

		/// <summary>
		/// Total score of the player.
		/// </summary>
		public int Score { get; set; }

		/// <summary>
		/// Adds player to the team.
		/// </summary>
		/// <param name="team"></param>
		private void AddPlayerToTeam(Team team)
		{
			// ask yumit, can we do try and catch block?
			if (Branch != team.Branch)
			{
				string message = "You can not add the players to the team which they are in different branches.";
				throw new Exception(message);
			}
			team.Players.Add(this);
		}
		#endregion

	}
}
