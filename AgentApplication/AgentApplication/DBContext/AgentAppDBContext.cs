using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AgentApplication.Model;

namespace AgentApplication.DBContext
{
	public class AgentAppDBContext : DbContext
	{
		public DbSet<Accommodation> Accommodations { get; set; }
		public DbSet<AccommodationUnit> AccommodationUnits { get; set; }
		public DbSet<AccommodationUnitType> AccommodationUnitTypes { get; set; }
		public DbSet<Address> Address { get; set; }
		public DbSet<CommentRate> CommentRates { get; set; }
		public DbSet<Image> Images { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<PeriodPrice> PeriodPrices { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<User> User { get; set; }

		/*protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Reservation>()
			.HasOptional<User>(s => s.Guest)
			.WithMany()
			.WillCascadeOnDelete(false);
			
		}*/
	}
}
