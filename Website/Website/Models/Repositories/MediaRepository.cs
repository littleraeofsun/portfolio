using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class MediaRepository<T> : Repository<T> where T : Media
    {
        public IQueryable<T> GetByProject(int ProjectId)
        {
            return dbSet.Where(i => i.ProjectId == ProjectId);
        }
        public IQueryable<T> GetByAlbum(int AlbumId)
        {
            return dbSet.Where(i => i.AlbumId == AlbumId);
        }
    }
}