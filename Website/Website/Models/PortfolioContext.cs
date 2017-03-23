using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Rae.Website.Models
{
    public class PortfolioContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
    }
}