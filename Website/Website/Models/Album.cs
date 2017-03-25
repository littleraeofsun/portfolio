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

        public virtual List<Media> Media { get; set; }
    }
}