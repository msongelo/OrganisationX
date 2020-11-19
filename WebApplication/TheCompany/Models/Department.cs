using System;
using System.Collections.Generic;

namespace TheCompany.Models
{
    public partial class Department
    {
        public int DepartId { get; set; }
        public int? UserId { get; set; }
        public string DepartmentType { get; set; }
        public string JobRole { get; set; }
        public string JobLevel { get; set; }
        public string BusinessTravel { get; set; }
    }
}
