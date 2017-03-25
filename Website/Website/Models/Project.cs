using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rae.Website.Models
{
    public class Project
    {

        public int ProjectId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Customer { get; set; }

        [StringLength(255)]
        public string Url { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [StringLength(200)]
        public string Categories { get; set; }
        
        public virtual List<Media> Media { get; set; }
    }
}