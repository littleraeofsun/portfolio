using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rae.Website.Models
{
    public class Image
    {
        public int ImageId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

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


        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}