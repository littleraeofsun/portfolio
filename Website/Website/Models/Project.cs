using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Customer { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string[] Tags { get; set; }
    }
}