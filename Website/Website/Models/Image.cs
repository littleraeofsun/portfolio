using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rae.Website.Models
{
    public class Image : Media
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Url of Large Resolution")]
        public string UrlLarge { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Url of Medium Resolution")]
        public string UrlMedium { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Url of Small Resolution")]
        public string UrlSmall { get; set; }
    }
}