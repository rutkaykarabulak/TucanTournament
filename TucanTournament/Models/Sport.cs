using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TucanTournament.Utils;

namespace TucanTournament.Models
{
	public abstract class Sport
	{
		/// <summary>
		/// Type of the sport.
		/// </summary>
		public Types.SportType Type { get; set; }

		/// <summary>
		/// Which federation does sport belong?
		/// </summary>
		public string Federation { get; set; } = "";

		/// <summary>
		/// Id of the sport
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Name of the sport
		/// </summary>
		public string Name { get; set; } = "";


	}
}
