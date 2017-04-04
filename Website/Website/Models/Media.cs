using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rae.Website.Models
{
    public abstract class Media
    {
        public int MediaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int? ProjectId { get; set; }
        [JsonIgnore]
        public virtual Project Project { get; set; }
        
        public int? AlbumId { get; set; }
        [JsonIgnore]
        public virtual Album Album { get; set; }
    }
}