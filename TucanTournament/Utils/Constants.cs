using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TucanTournament.Utils
{
	public class Constants
	{
		public static readonly int WinnterTeamBonus = 10;

		// Basketball points

		public static readonly int GuardAssist = 1;
		public static readonly int ForwardAssist = 2;
		public static readonly int CenterAssist = 3;

		public static readonly int GuardRebound = 3;
		public static readonly int ForwardRebound = 2;
		public static readonly int CenterRebound = 1;

		public static readonly int Scored = 2;

		// Handball points

		public static readonly int InitialRatingPointGoalkeeper = 50;
		public static readonly int InitialRatingPointFieldPlayer = 20;

		public static readonly int GoalkeeperGoalMade = 5;
		public static readonly int GoalkeeperGoalReceived = -2;

		public static readonly int FieldPlayerGoalMade = 1;
		public static readonly int FieldPlayerGoalReceived = -1;
	}
}
