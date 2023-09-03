using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndMeARoomate.DataLayer.Models
{
    public class Anouncement
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime PublishedDate { get; set; }

        public bool IsActive { get; set; }


    }
}
