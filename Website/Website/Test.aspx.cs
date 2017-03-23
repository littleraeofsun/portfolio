using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
                context.Projects.Add(new Project() { Title = "Ashcorp Technologies", Customer = "Brian Smith", Url = "http://www.ashcorptechnologies.com", Tags = new string[] { "Website", "Branding", "Content Writing" }, Description = "As a part of a family investment opportunity, I helped out the originator of Ashcorp technologies by building up his branding and delivering him a presentation website in exchange for equity in his company. Everything you see on his website was done by me." });
                context.SaveChanges();
                projectCount = context.Projects.Count();
            }
        }
    }
}