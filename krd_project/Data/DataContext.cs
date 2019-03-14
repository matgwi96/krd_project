using krd_project.API.People.Workers;
using krd_project.API.People.Bosses;
using Microsoft.EntityFrameworkCore;

namespace krd_project.API.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Worker> Workers { get; set; }
		public DbSet<Boss> Bosses { get; set; }
	} 
}
