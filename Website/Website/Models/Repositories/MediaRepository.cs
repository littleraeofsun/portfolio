using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class MediaRepository : Repository<Media>
    {
        public List<Media> GetProjectMedia(int ProjectId)
        {
            return dbSet.Where(i => i.Project.ProjectId == ProjectId).ToList();
        }
    }
}