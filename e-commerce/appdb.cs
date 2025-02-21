using e_commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace e_commerce
{
	public class appdb:DbContext
	{
		public DbSet<category> categories {  get; set; }
		public DbSet<product> products { get; set; }
        public appdb(DbContextOptions<appdb> options) : base(options) { }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	base.OnConfiguring(optionsBuilder);
		//}
	}
}
