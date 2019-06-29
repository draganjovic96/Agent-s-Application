using AgentApplication.AccommodationUnitService;
using AgentApplication.DBContext;
using AgentApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApplication.Service
{
	public class AccommodationUnitService
	{
		private AccommodationUnitPortClient client = new AccommodationUnitPortClient();

		private AgentAppDBContext context = new AgentAppDBContext();

		public List<AccommodationUnit> getAccommodationUnits(long id) {
			List<AccommodationUnit> units = new List<AccommodationUnit>();
			try
			{
				getAccommodationUnitsRequest unitsRequest = new getAccommodationUnitsRequest() { id = 1 };
				getAccommodationUnitsResponse unitsResponse = client.getAccommodationUnits(unitsRequest);
				foreach(accommodationUnit unit in unitsResponse.accommodationUnits)
				{
					AccommodationUnit newUnit = new AccommodationUnit(unit);
					units.Add(newUnit);
					context.AccommodationUnits.Add(newUnit);
					context.SaveChanges();
				}
				return units;
			}
			catch (Exception e)
			{
				return null;
			}
		}
	}
}
