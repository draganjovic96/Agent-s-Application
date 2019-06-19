using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AgentApplication.Model
{
	public enum AccommodationType
	{

		HOTEL,
		MOTEL,
		BAD_AND_BREAKFAST
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://booking.uns.ac.rs/accommodation")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://booking.uns.ac.rs/accommodation", IsNullable = false)]

	public class Accommodation
	{

		private List<Service> service { get; set; }

		private string description { get; set; }

		private string name { get; set; }

		private List<Image> images { get; set; }

		private List<AccommodationUnit> accommodationUnits { get; set; }

		private List<User> agents { get; set; }

		private String category { get; set; }

		private Address address { get; set; }

		private AccommodationType accommodationType { get; set; }

		private long id { get; set; }

	}
}
