using AgentApplication.AddressService;
using AgentApplication.DBContext;
using AgentApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApplication.Service
{
	public class AddressService
	{
		public AgentAppDBContext context = new AgentAppDBContext();

		public AgentApplication.AddressService.AddressPortClient client = new AddressPortClient();
		public Address getAddress(long id)
		{
			getAddressRequest request = new getAddressRequest()
			{
				id = id
			};
			try
			{
				getAddressResponse response = client.getAddress(request);
				return new Address(response.address);
			}
			catch
			{
				return null;
			}
			
		}
		public Address addAddress(Address address)
		{
			addAddressRequest request = new addAddressRequest()
			{
				address = new address()
				{
					Country = address.Country,
					City = address.City,
					Street = address.Street,
					Number = address.Number,
					Postal_code = address.PostalCode,
					Latitude = address.Latitude,
					Longitude = address.Longitude,
					Apartment_number = address.ApartmentNumber
				}
			};
			addAddressResponse response = client.addAddress(request);
			if (response.success)
			{
				return getAddress(address.Id);
			}
			else
			{
				return null;
			}
		}
	}
}
