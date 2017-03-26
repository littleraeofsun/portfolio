using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class AlbumRepository : Repository<Album>
    {
        public IQueryable<Album> GetByName(string Name, bool Exact = true)
        {
            if(Exact)
                return dbSet.Where(a => a.Name.ToLower() == Name.ToLower());
            else
                return dbSet.Where(a => a.Name.ToLower().Contains(Name.ToLower()));
        }

        public IQueryable<Album> GetByDescription(string Term)
        {
            return dbSet.Where(p => p.Description.ToLower().Contains(Term.ToLower()));
        }
    }
}