using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TucanTournament.Utils
{
	public class Types
	{
		/// <summary>
		/// Type of the sport.
		/// You can extend this enum to add more sport.
		/// </summary>
		public enum SportType
		{
			Basketball, // 0
			Handball // 1
		}

		/// <summary>
		///  Position where player plays.
		/// </summary>
		public enum PlayerPosition
		{
			// Basketball 

			Guard, // 0 
			Forward, // 1 
			Center, // 2
			
			// Handball
			Goalkeeper, // 3
			FieldPlayer // 4
		}

	}
}
