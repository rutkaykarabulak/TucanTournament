using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
