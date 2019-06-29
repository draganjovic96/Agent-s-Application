using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentApplication.AccommodationUnitService;

namespace AgentApplication.Model
{

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://booking.uns.ac.rs/accommodation")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://booking.uns.ac.rs/accommodation", IsNullable = false)]

	public class AccommodationUnit
	{
		public int Floor { get; set; }

		[Required]
		public string Number { get; set; }

		public int NumberOfBeds { get; set; }

		public double DefaultPrice { get; set; }

		public bool Deleted;	

		public List<PeriodPrice> PeriodPrices { get; set; }

		public List<Reservation> Reservations { get; set; }

		[Required]
		public AccommodationUnitType AccommodationUnitType { get; set; }

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public long Id { get; set; }

		[Required]
		public Accommodation Accommodation { get; set; }

		public AccommodationUnit(accommodationUnit unit)
		{
			Id = unit.Id;
			Accommodation = new Accommodation(unit.Accommodation);
			Floor = unit.Floor;
			Number = unit.Number;
			Deleted = false;
			NumberOfBeds = unit.NumberOfBeds;
			DefaultPrice = unit.DefaultPrice;
			AccommodationUnitType = (AccommodationUnitType)Enum.Parse(typeof(AccommodationUnitType), unit.AccommodationUnitType.ToString(), true); 
		}
	}
}
