﻿using AgentApplication.UserService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApplication.Model
{
	public enum UserRole
	{
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
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public long id { get; set; }

		[Required]
		public string name { get; set; }

		[Required]
		public string lastname { get; set; }

		[StringLength(50)]
		[Index(IsUnique = true)]
		public string email { get; set; }

		[StringLength(50)]
		[Index(IsUnique = true)]
		public string username { get; set; }

		[Required]
		public string password { get; set; }

		[Required]
		public bool enabled { get; set; }

		public bool deleted { get; set; }

		[Required]
		public UserRole role { get; set; }

		[Required]
		public Address address { get; set; }

		[Required]
		public long businessRegistrationNumber { get; set; }

		[Required]
		public bool blocked { get; set; }

		public Accommodation AgentOfAccommodation { get; set; }

		public User(UserService.user User)
		{

			id = User.Id;
			name = User.Name;
			lastname = User.Lastname;
			username = User.Username;
			email = User.Email;
			password = User.Password;
			enabled = User.Enabled;
			deleted = User.Deleted;
			role = (UserRole)Enum.Parse(typeof(UserRole), User.Role.ToString(), true);
			address = new Address(User.Address);
			blocked = User.Blocked;
			businessRegistrationNumber = User.Bussines_registration_number;
		}

		public User()
		{
		}

		public User(MessageService.user User)
		{

			id = User.Id;
			name = User.Name;
			lastname = User.Lastname;
			username = User.Username;
			email = User.Email;
			password = User.Password;
			enabled = User.Enabled;
			deleted = User.Deleted;
			role = (UserRole)Enum.Parse(typeof(UserRole), User.Role.ToString(), true);
			address = new Address(User.Address);
			blocked = User.Blocked;
			businessRegistrationNumber = User.Bussines_registration_number;
		}

		public User(ReservationService.user User)
		{

			id = User.Id;
			name = User.Name;
			lastname = User.Lastname;
			username = User.Username;
			email = User.Email;
			password = User.Password;
			enabled = User.Enabled;
			deleted = User.Deleted;
			role = (UserRole)Enum.Parse(typeof(UserRole), User.Role.ToString(), true);
			address = new Address(User.Address);
			blocked = User.Blocked;
			businessRegistrationNumber = User.Bussines_registration_number;
		}
	}
}
