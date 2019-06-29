using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
	public class Message
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public long Id { get; set; }

		public string MessageContent { get; set; }

		public bool Seen { get; set; }

		public User Sender { get; set; }

		public User Receiver { get; set; }

		public DateTime DatumVreme { get; set; }

		public bool Deleted { get; set; }

		public Reservation Reservation { get; set; }

		public Accommodation Accommodation { get; set; }

	}
}
