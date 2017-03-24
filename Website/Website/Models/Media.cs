﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rae.Website.Models
{
    public class Media
    {
        public int MediaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string Url { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}