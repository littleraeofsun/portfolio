using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class ImageRepository : MediaRepository<Image>
    {
        public IQueryable<Image> GetByUrl(string Url)
        {
            return dbSet.Where(i => i.UrlLarge.Contains(Url) || i.UrlMedium.Contains(Url) || i.UrlSmall.Contains(Url));
        }
    }
}