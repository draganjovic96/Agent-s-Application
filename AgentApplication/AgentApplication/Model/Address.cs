using AgentApplication.UserService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApplication.Model
{

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://booking.uns.ac.rs/users")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://booking.uns.ac.rs/users", IsNullable = false)]

	public class Address : INotifyPropertyChanged
	{
		[Required]
		private string country;

		[Required]
		private string city;

		private int postalCode;

		[Required]
		private string street;

		[Required]
		private string number;

		private string apartmentNumber;

		private double longitude;

		private double latitude;

		[Required]
		private bool deleted;

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public long Id { get; set; }

		public string Country { get => country; set { country = value; OnPropertyChanged("Country");  } }
		public string City { get => city; set { city = value; OnPropertyChanged("City"); } }
		public string Street { get => street; set { street = value; OnPropertyChanged("Street"); } }
		public string Number { get => number; set { number = value; OnPropertyChanged("Number"); } }
		public string ApartmentNumber { get => apartmentNumber; set { apartmentNumber = value; OnPropertyChanged("ApartmentNubmer"); } }
		public double Longitude { get => longitude; set { longitude = value; OnPropertyChanged("Longitude"); } }
		public double Latitude { get => latitude; set { latitude = value; OnPropertyChanged("Latitude"); }	}
		public bool Deleted { get => deleted; set { deleted = value; OnPropertyChanged("Deleted"); } }
		public int PostalCode { get => postalCode; set { postalCode = value; OnPropertyChanged("PostalCode"); } }

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string PropertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
			}
		}

		public Address(UserService.Address address)
		{
			this.Id = address.Id;
			this.Country = address.Country;
			this.City = address.City;
			this.PostalCode = address.Postal_code;
			this.Street = address.Street;
			this.Number = address.Number;
			this.ApartmentNumber = address.Apartment_number;
			this.Longitude = address.Longitude;
			this.Latitude = address.Latitude;
			this.Deleted = false;
		}

		public Address(AccommodationService.Address address)
		{
			this.Id = address.Id;
			this.Country = address.Country;
			this.City = address.City;
			this.PostalCode = address.Postal_code;
			this.Street = address.Street;
			this.Number = address.Number;
			this.ApartmentNumber = address.Apartment_number;
			this.Longitude = address.Longitude;
			this.Latitude = address.Latitude;
			this.Deleted = false;
		}

		public Address(AccommodationUnitService.Address address)
		{
			this.Id = address.Id;
			this.Country = address.Country;
			this.City = address.City;
			this.PostalCode = address.Postal_code;
			this.Street = address.Street;
			this.Number = address.Number;
			this.ApartmentNumber = address.Apartment_number;
			this.Longitude = address.Longitude;
			this.Latitude = address.Latitude;
			this.Deleted = false;
		}

		public Address(AddressService.address address)
		{
			this.Id = address.Id;
			this.Country = address.Country;
			this.City = address.City;
			this.PostalCode = address.Postal_code;
			this.Street = address.Street;
			this.Number = address.Number;
			this.ApartmentNumber = address.Apartment_number;
			this.Longitude = address.Longitude;
			this.Latitude = address.Latitude;
			this.Deleted = false;
		}

		public Address(MessageService.address address)
		{
			this.Id = address.Id;
			this.Country = address.Country;
			this.City = address.City;
			this.PostalCode = address.Postal_code;
			this.Street = address.Street;
			this.Number = address.Number;
			this.ApartmentNumber = address.Apartment_number;
			this.Longitude = address.Longitude;
			this.Latitude = address.Latitude;
			this.Deleted = false;
		}

		public Address(PeriodPriceService.Address address)
		{
			this.Id = address.Id;
			this.Country = address.Country;
			this.City = address.City;
			this.PostalCode = address.Postal_code;
			this.Street = address.Street;
			this.Number = address.Number;
			this.ApartmentNumber = address.Apartment_number;
			this.Longitude = address.Longitude;
			this.Latitude = address.Latitude;
			this.Deleted = false;
		}

		public Address(ReservationService.address address)
		{
			this.Id = address.Id;
			this.Country = address.Country;
			this.City = address.City;
			this.PostalCode = address.Postal_code;
			this.Street = address.Street;
			this.Number = address.Number;
			this.ApartmentNumber = address.Apartment_number;
			this.Longitude = address.Longitude;
			this.Latitude = address.Latitude;
			this.Deleted = false;
		}

		public Address()
		{
		}
	}
}
