using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AgentApplication.Model;

namespace AgentApplication.DBContext
{
	public class AddressDBContext : DbContext
	{
		public DbSet<Address> Address { get; set; }

	}
}
