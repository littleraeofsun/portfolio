using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class ProjectRepository : Repository<Project>
    {
        public List<Project> GetByTitle(string Title)
        {
            return dbSet.Where(p => p.Title == Title).ToList();
        }
    }
}