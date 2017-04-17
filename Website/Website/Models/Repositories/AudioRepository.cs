using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class AudioRepository : MediaRepository<Audio>
    {
        public IQueryable<Audio> GetByUrl(string Url)
        {
            return dbSet.Where(i => i.AudioUrl.Contains(Url));
        }
    }
}