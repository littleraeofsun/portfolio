using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class ImageRepository : Repository<Image>
    {
        public List<Image> GetProjectImages(int ProjectId)
        {
            return dbSet.Where(i => i.Project.ProjectId == ProjectId).ToList();
        }
    }
}