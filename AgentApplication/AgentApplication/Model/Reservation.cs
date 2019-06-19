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
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://booking.uns.ac.rs/reservation")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://booking.uns.ac.rs/reservation", IsNullable = false)]
	public class Reservation
	{

		private DateTime fromDate { get; set; }

		private DateTime toDateField { get; set; }

		private bool confirmedField { get; set; }

		private ReservationConversation conversationField { get; set; }

		private ReservationComment_rate commentRateField { get; set; }

		private AccommodationUnit accommodationUnitField { get; set; }

		private User guest;

		private long id;
				
	}
}
