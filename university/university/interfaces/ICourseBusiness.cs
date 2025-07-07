using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university.Entities;

namespace university.interfaces
{
    internal interface ICourseBusiness
    {
        public List<Course> SearchCourse(string majorGroup , string courseType);
        public bool SelectCourse();
    }
}
