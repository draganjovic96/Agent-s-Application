using AgentApplication.AccommodationService;
using AgentApplication.DBContext;
using AgentApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApplication.Service
{
	public class AccommodationService
	{
		private AccommodationPortClient client = new AccommodationPortClient();

		private AgentAppDBContext context = new AgentAppDBContext();

		public Accommodation getAccommodationByUserId(User user)
		{
			getAccommodationByUserRequest request = new getAccommodationByUserRequest()
			{
				username = user.username
			};
			try
			{
				getAccommodationByUserResponse response = client.getAccommodationByUser(request);
				Accommodation newAccommodation = new Accommodation(response.accommodation);
				context.Accommodations.Add(newAccommodation);
				context.SaveChanges();
				return newAccommodation;
			}
			catch (Exception e)
			{
				return null;
			}
		}

		public bool addAccommodation(Accommodation newAccommodation)
		{

			addAccommodationRequest request = new addAccommodationRequest()
			{
				accommodation = new accommodation()
				{
					Name = newAccommodation.Name,
					Description = newAccommodation.Description,
					Address = new AgentApplication.AccommodationService.Address()
					{
						Country = newAccommodation.Address.Country,
						City = newAccommodation.Address.City,
						Longitude = newAccommodation.Address.Longitude,
						Latitude = newAccommodation.Address.Latitude,
						Street = newAccommodation.Address.Street,
						Number = newAccommodation.Address.Number,
						Postal_code = newAccommodation.Address.PostalCode,
						Apartment_number = newAccommodation.Address.ApartmentNumber
					},
					Category = newAccommodation.Category,
					AccommodationType = (accommodationType)Enum.Parse(typeof(accommodationType), newAccommodation.AccommodationType.ToString(), true),
				}
			};

			try
			{
				addAccommodationResponse response = client.addAccommodation(request);
				if(!context.Accommodations.Any(info => info.Id == response.accommodation.Id))
					context.Accommodations.Add(new Accommodation(response.accommodation));
				context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public void updateAccommodation(Accommodation accommodation)
		{
			updateAccommodationRequest request = new updateAccommodationRequest()
			{
				accommodation = new accommodation()
				{
					Id = accommodation.Id,
					Name = accommodation.Name,
					Description = accommodation.Description,
					Category = accommodation.Category,
					AccommodationType = (accommodationType)Enum.Parse(typeof(accommodationType), accommodation.AccommodationType.ToString(), true),
					Address = new AgentApplication.AccommodationService.Address()
					{
						Country = accommodation.Address.Country,
						City = accommodation.Address.City,
						Longitude = accommodation.Address.Longitude,
						Latitude = accommodation.Address.Latitude,
						Street = accommodation.Address.Street,
						Number = accommodation.Address.Number,
						Id = accommodation.Address.Id,
						Postal_code = accommodation.Address.PostalCode,
						Apartment_number = accommodation.Address.ApartmentNumber
					},
				}
			};
			client.updateAccommodation(request);
			context.SaveChanges();
		}

		public bool deleteAccommodation(long accommodationId)
		{
			try
			{
				removeAccommodationRequest request = new removeAccommodationRequest()
				{
					id = accommodationId
				};
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
