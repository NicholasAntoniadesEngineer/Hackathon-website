using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePowerRanges.Models
{
    public class UserReadModel
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string DateOfBirth { get; set; }
        public string AccountType { get; set; }
    }
}
