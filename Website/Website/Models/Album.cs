using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rae.Website.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [StringLength(1000)]
        public string Description { get; set; }

        public bool IsFeatured { get; set; }

        public virtual IQueryable<Media> Media { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Url of Large Resolution Featured Image")]
        public string FeaturedImageUrlLarge { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Url of Medium Resolution Featured Image")]
        public string FeaturedImageUrlMedium { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Url of Small Resolution Featured Image")]
        public string FeaturedImageUrlSmall { get; set; }
    }
}