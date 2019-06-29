using AgentApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApplication.ViewModel
{
	public class UnitsViewModel
	{
		private List<AccommodationUnit> units;

		public UnitsViewModel(User loggedUser)
		{
		}

		public List<AccommodationUnit> Units { get => units; set => units = value; }
	}
}
