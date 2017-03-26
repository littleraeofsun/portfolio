using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class VideoRepository : MediaRepository<Video>
    {
        public IQueryable<Video> GetByUrl(string Url)
        {
            return dbSet.Where(i => i.VideoUrl.Contains(Url));
        }
    }
}