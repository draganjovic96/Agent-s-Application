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
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://booking.uns.ac.rs/users")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://booking.uns.ac.rs/users", IsNullable = false)]

	public class Address
	{
		[Required]
		public string country { get; set; }

		[Required]
		public string city { get; set; }

		public int postalCode { get; set; }

		[Required]
		public string street { get; set; }

		[Required]
		public string number { get; set; }

		public string apartmentNumber { get; set; }

		public double longitude { get; set; }

		public double latitude { get; set; }

		[Required]
		public bool deleted { get; set; }

		[Key]
		public long id { get; set; }

	}
}
