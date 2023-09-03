using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIndMeARoomate.DataLayer.Models
{
    public class Applications
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Student")]
        public int ApplicantID { get; set; }

        public Student Student { get; set; }

        [ForeignKey("Anouncement")]
        [Required]
        public int AnouncementID { get; set; }

        public Anouncement Anouncement { get; set; }

        public string Status { get; set; }


    }
}
