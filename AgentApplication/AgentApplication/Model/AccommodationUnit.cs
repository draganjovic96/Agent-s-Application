using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public long Id { get; set; }

		[Required]
		public Accommodation Accommodation { get; set; }
	}
}
