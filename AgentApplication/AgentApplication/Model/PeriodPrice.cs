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
	public class PeriodPrice
	{
		[Key]
		public long Id { get; set; }

		public DateTime FromDate { get; set; }

		public DateTime ToDate { get; set; }

		public double Pice { get; set; }

		public bool Deleted { get; set; }

		public AccommodationUnit AccommodationUnit { get; set; }
	}
	
}
