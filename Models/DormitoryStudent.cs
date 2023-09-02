using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndMeARoomate.Models
{
    internal class DormitoryStudent
    {
        public int ID { get; set; }

        public Student StudentID { get; set; }

        public Dormitory DormitoryID { get; set; }
    }
}
