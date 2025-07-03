using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university.interfaces
{
    internal interface IStudentBusiness
    {
        public bool ChangePassword(string mobileNumber, string newPassword);

        public bool ShowInfo(string firstName , string lastName , string nationalCode , string studentCode );
    }
}
