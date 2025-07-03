using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university.Entities
{
    internal class StudentLesson
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int StudentId { get; set; }
        public int Cpasity { get; set; }
       
    }
}
