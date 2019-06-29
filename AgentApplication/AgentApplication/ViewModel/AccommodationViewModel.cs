using AgentApplication.DBContext;
using AgentApplication.Model;
using AgentApplication.View;
using AgentApplication.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AgentApplication.ViewModel
{
	public class AccommodationViewModel : ViewModelBase
	{
		private Service.AccommodationService accommodationService = new Service.AccommodationService();
		private AgentAppDBContext context = new AgentAppDBContext();

		public User LoggedUser { get; set; }

		private Accommodation accommodation;

		private string updateButton = "Update";
		private string deleteButton = "Delete";

		private string addressString = "";
		private List<AccommodationType> accommodationType = (Enum.GetValues(typeof(AccommodationType))).OfType<AccommodationType>().ToList();

		public UpdateAddressCommand UpdateAddressCommand { get; set; }

		public AddressWindow AddressWindow { get; set; }

		public AddUpdateAccommodationCommand AddUpdateAccommodationCommand { get; set; }
		public AccommodationViewModel(User loggedUser)
		{
			this.LoggedUser = loggedUser;
			this.Accommodation = accommodationService.getAccommodationByUserId(loggedUser);
			this.AddUpdateAccommodationCommand = new AddUpdateAccommodationCommand(this);

			if (Accommodation == null)
			{
				Accommodation = new Accommodation();
				Accommodation.Address = new Address();
				AccommodationDoesnotExist();
			}
			else
			{
				AccommodationExist();
			}
			this.UpdateAddressCommand = new UpdateAddressCommand(this);
			AddressWindow = new AddressWindow(accommodation.Address);

		}

		public string UpdateButton
		{
			get => updateButton;
			set
			{
				updateButton = value;
				OnPropertyChanged("UpdateButton");
			}
		}
		public string DeleteButton
		{
			get => deleteButton;
			set {
				deleteButton = value;
				OnPropertyChanged("DeleteButton");
			}
		}

		public string AddressString { get => addressString; set { addressString = value; OnPropertyChanged("AddressString"); } }

		public Accommodation Accommodation {
			get => accommodation;
			set
			{
				accommodation = value;
			}
		}

		public List<AccommodationType> AccommodationType { get => accommodationType; set => accommodationType = value; }

		public void AccommodationDoesnotExist()
		{
			AddressString = "";
			UpdateButton = "Add";
			DeleteButton = "Cancel";
		}

		public void AccommodationExist()
		{
			AddressString = Accommodation.Address.City + ", " + Accommodation.Address.Street + " " + Accommodation.Address.Number;
			UpdateButton = "Update";
			DeleteButton = "Delete";
		}

		public void DeleteAccommodation()
		{
			if (accommodationService.deleteAccommodation(Accommodation.Id))
			{
				context.Accommodations.Remove(Accommodation);
				context.SaveChanges();
			}
			else
			{
				MessageBox.Show("Can't delete accommodation.");
			}
		}

		public void updateAddress()
		{
			AddressWindow addressWindow = new AddressWindow(Accommodation.Address);
			//addressWindow.Show();
			if (addressWindow.ShowDialog() == false)
			{
				Accommodation.Address = ((AddressViewModel)addressWindow.DataContext).Address;
				AddressString = Accommodation.Address.City + ", " + Accommodation.Address.Street + " " + Accommodation.Address.Number;
			}
		}
		public IEnumerable<AccommodationType> AccommodationTypes
		{
			get
			{
				return Enum.GetValues(typeof(AccommodationType)).Cast<AccommodationType>();
			}
		}

		public void AddOrUpdateAccommodation()
		{
			if (accommodationService.getAccommodationByUserId(LoggedUser) == null)
			{
				if (accommodationService.addAccommodation(Accommodation))
				{
					Accommodation = accommodationService.getAccommodationByUserId(LoggedUser);
					MessageBox.Show("Accommodation added!");
				}
				else
				{
					MessageBox.Show("Can't add accommodation!");
				}
			}
			else
			{
				accommodationService.updateAccommodation(Accommodation);
				Accommodation = accommodationService.getAccommodationByUserId(LoggedUser);
				MessageBox.Show("Accommodation updated!");
			}
		}
	}
}
