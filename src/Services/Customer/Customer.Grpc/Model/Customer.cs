using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Grpc.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string IdNumber { get; set; }
        public string FirsName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Movil { get; set; }

    }
}
