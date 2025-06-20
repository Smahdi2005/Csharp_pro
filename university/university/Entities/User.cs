using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university.Entities
{
    internal class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NationalCode { get; set; }

        public string MobileNumber { get; set; }
        public DateTime BirthDate { get; set; }

        public bool IsAdmin { get; set; }





    }
}
