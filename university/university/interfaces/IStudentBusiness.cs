﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university.Entities;

namespace university.interfaces
{
    internal interface IStudentBusiness
    {
        public bool ChangePassword(string mobileNumber, string newPassword);

        public Student ShowInfo(int id);
    }
}
