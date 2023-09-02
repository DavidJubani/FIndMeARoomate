using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndMeARoomate.Models
{
    internal class Applications
    {
        public int ID { get; set; }

        public Student StudentID { get; set; }

        public Anouncement AnouncementID { get; set; }

        public DateTime ApplicationDate { get; set; }

        public bool IsActive { get; set; }

      
    }
}
