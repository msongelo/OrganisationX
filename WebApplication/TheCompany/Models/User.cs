using System;
using System.Collections.Generic;

namespace TheCompany.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string EmployeeNum { get; set; }
    }
}
