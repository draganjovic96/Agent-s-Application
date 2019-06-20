using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

		[Key]
		public long id { get; set; }

		public List<Service> Services { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public string Name { get; set; }

		public List<Image> Images { get; set; }
		
		public List<AccommodationUnit> AccommodationUnits { get; set; }

		public List<User> Agents { get; set; }

		[Required]
		public String Category { get; set; }

		[Required]
		public Address Address { get; set; }

		[Required]
		public AccommodationType AccommodationType { get; set; }

	}
}
