using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApplication.Model
{
	public enum UserRole {
		REGISTERED_USER,
		AGENT,
		ADMINISTRATOR
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://booking.uns.ac.rs/users")]
	public class User
	{

		private string name { get; set; }

		private string lastname { get; set; }

		private string email { get; set; }

		private string username { get; set; }

		private string password { get; set; }

		private long id { get; set; }

		private bool enabled { get; set; }

		private bool deleted { get; set; }

		private UserRole role { get; set; }

		private Address address { get; set; }

		private long businessRegistrationNumber { get; set; }

		private bool blocked { get; set; }

	}
}
