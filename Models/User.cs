using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace truckAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }
        public int CompanyId { get; set; }
        public Company MyProperty { get; set; }

    }
}