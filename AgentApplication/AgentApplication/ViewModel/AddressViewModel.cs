using AgentApplication.Model;
using AgentApplication.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApplication.ViewModel
{
	public class AddressViewModel
	{
		private Service.AccommodationService accommodationService = new Service.AccommodationService();
		public Address Address { get; set; }

		public AddressViewModel(Address address)
		{
			Address = address;
		}

	}
}
