using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
