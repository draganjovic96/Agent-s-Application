using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using AgentApplication.AccommodationService;

namespace AgentApplication.Model
{
	public enum AccommodationType
	{
		[Description("Hotel")]
		HOTEL,
		[Description("Motel")]
		MOTEL,
		[Description("Bed&Breakfast")]
		BED_AND_BREAKFAST
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://booking.uns.ac.rs/accommodation")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://booking.uns.ac.rs/accommodation", IsNullable = false)]
	
	public class Accommodation : INotifyPropertyChanged
	{

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public long Id { get; set; }

		private List<Service> services;

		[Required]
		private string description;

		[Required]
		private string name;

		private List<AccommodationUnit> accommodationUnits;

		[Required]
		private List<User> agents;

		[Required]
		private string category;

		[Required]
		private Address address;

		[Required]
		private AccommodationType accommodationType;

		public List<Service> Services
		{
			get => services;
			set
			{
				services = value;
			}
		}
		public string Description
		{
			get => description;
			set
			{
				description = value;
				OnPropertyChanged("Description");
			}
		}
		public string Name
		{
			get => name;
			set
			{
				name = value;
				OnPropertyChanged("Name");

			}
		}
		public List<AccommodationUnit> AccommodationUnits
		{
			get => accommodationUnits;
			set => accommodationUnits = value;
		}
		public List<User> Agents
		{
			get => agents;
			set => agents = value;
		}
		public string Category
		{
			get => category;
			set
			{
				category = value;
				OnPropertyChanged("Category");
			}
		}
		public Address Address
		{
			get => address;
			set => address = value;
		}
		public AccommodationType AccommodationType
		{
			get => accommodationType;
			set
			{
				accommodationType = value;
				OnPropertyChanged("AccommodationType");
			}
		}

		public Accommodation(AccommodationService.accommodation accommodation)
		{
			this.Id = accommodation.Id;
			this.Name = accommodation.Name;
			this.Address = new Address(accommodation.Address);
			this.Category = accommodation.Category;
			this.AccommodationType = (AccommodationType)Enum.Parse(typeof(AccommodationType), accommodation.AccommodationType.ToString(), true);
			this.Description = accommodation.Description;
		}

		public Accommodation(AccommodationUnitService.accommodation accommodation)
		{
			this.Id = accommodation.Id;
			this.Name = accommodation.Name;
			this.Address = new Address(accommodation.Address);
			this.Category = accommodation.Category;
			this.AccommodationType = (AccommodationType)Enum.Parse(typeof(AccommodationType), accommodation.AccommodationType.ToString(), true);
			this.Description = accommodation.Description;
		}

		public Accommodation()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string PropertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
			}
		}
	}
}
