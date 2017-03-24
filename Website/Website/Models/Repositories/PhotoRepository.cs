using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class PhotoRepository : Repository<Photo>
    {
        public List<Photo> GetAlbumPhotos(int AlbumId)
        {
            return dbSet.Where(i => i.Album.AlbumId == AlbumId).ToList();
        }
    }
}