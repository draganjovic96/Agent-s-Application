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
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://booking.uns.ac.rs/reservation")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://booking.uns.ac.rs/reservation", IsNullable = false)]
	public class Reservation
	{
		[Key]
		public long Id { get; set; }

		public DateTime FromDate { get; set; }

		public DateTime ToDate { get; set; }

		public bool Confirmed { get; set; }

		public bool AgentConfirmed { get; set; }

		public CommentRate CommentRate { get; set; }

		[Required]
		public AccommodationUnit AccommodationUnit { get; set; }

		public List<Message> Messages { get; set; }

		public User Guest { get; set; }
				
	}
}
