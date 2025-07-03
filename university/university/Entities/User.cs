using BaseBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university.Entities
{
    internal class User : IFullEntity<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NationalCode { get; set; }

        public string MobileNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDelete { get; set; }
        public int DeletedByUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DeletedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CreatedByUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
