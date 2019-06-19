using System;
using System.Collections.Generic;
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
		private int floor { get; set; }

		private string number { get; set; }

		private int numberOfBeds { get; set; }

		private double defaultPrice { get; set; }

		private PeriodPrice periodPriceField { get; set; }

		private AccommodationUnitType accommodationUnitType { get; set; }

		private long id;
	}
}
