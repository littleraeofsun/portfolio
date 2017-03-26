using System.Data.Entity;

namespace Rae.Website.Models
{
    public class PortfolioContext : DbContext
    { 
        public DbSet<Project> Projects { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Media> Media { get; set; }

        public PortfolioContext()
        {
            //this is how we would log our database queries if we didn't have the Glimpse.EF6 package installed for the SQL tab
            //Database.Log = s => Trace.TraceInformation(s);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //FluentApi configuration goes here
        }
    }
}