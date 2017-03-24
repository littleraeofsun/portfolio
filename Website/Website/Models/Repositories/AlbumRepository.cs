using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class AlbumRepository : Repository<Album>
    {
        public List<Album> GetAlbumsByName(string Name)
        {
            return dbSet.Where(a => a.Name.Contains(Name)).ToList();
        }
    }
}