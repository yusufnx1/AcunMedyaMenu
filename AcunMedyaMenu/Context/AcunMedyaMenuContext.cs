using AcunMedyaMenu.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaMenu.Context
{
	public class AcunMedyaMenuContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-N6665N4\\SQLEXPRESS; Initial Catalog= AcunMedyaMenuDb; " +
				"integrated Security=true; TrustServerCertificate=True;");
		}
		public DbSet<Product> Products { get; set; }
	}
}
