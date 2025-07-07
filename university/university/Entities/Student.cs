using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university.Entities
{
    public class Student : User
    {
        public string StudentCode { get; set; }
        public int MajorId { get; set; }
        public string MajorName { get; set; }
    }
}
