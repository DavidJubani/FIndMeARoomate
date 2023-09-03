using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIndMeARoomate.DataLayer.Models
{
    public class DormitoryStudent
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }

        public Student Student { get; set; }

        [ForeignKey("Dormitory")]
        public int DormitoryID { get; set; }

        public Dormitory Dormitory { get; set; }
    }
}
