using System;
using System.Linq;
using Rae.Website.Models;

namespace Rae.Website
{
    public partial class Test : System.Web.UI.Page
    {
        protected int projectCount = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            using (var context = new PortfolioContext())
            {
                projectCount = context.Projects.Count();
            }
        }
    }
}