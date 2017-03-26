using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rae.Website.Models
{
    public class Video : Media
    {
        [Required]
        [StringLength(255)]
        public string VideoUrl { get; set; }
    }
}