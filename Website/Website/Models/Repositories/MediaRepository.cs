using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class MediaRepository : Repository<Media>
    {
        #region Media Queries
        public IQueryable<Media> GetProjectMedia(int ProjectId)
        {
            return dbSet.Where(i => i.ProjectId == ProjectId);
        }
        public IQueryable<Media> GetAlbumMedia(int AlbumId)
        {
            return dbSet.Where(i => i.AlbumId == AlbumId);
        }

        public IQueryable<T> GetAllMediaOfType<T>() where T : Media
        {
            return dbSet.OfType<T>();
        }
        public IQueryable<T> GetProjectMediaOfType<T>(int ProjectId) where T: Media
        {
            return dbSet.OfType<T>().Where(x => x.ProjectId == ProjectId);
        }
        public IQueryable<T> GetAlbumMediaOfType<T>(int AlbumId) where T : Media
        {
            return dbSet.OfType<T>().Where(x => x.AlbumId == AlbumId);
        }
        #endregion

        #region Image Queries
        public IQueryable<Image> GetImagesByUrl(string Url)
        {
            return dbSet.OfType<Image>().Where(i => i.UrlLarge.Contains(Url) || i.UrlMedium.Contains(Url) || i.UrlSmall.Contains(Url));
        }
        #endregion

        #region Audio Queries
        #endregion

        #region Video Queries
        #endregion
    }
}