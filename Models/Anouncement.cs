﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndMeARoomate.Models
{
    internal class Anouncement
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime PublishedDate { get; set; }

        public bool IsActive { get; set; }


    }
}
