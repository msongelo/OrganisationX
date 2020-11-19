using System;
using System.Collections.Generic;

namespace TheCompany.Models
{
    public partial class WorkRecord
    {
        public int DepartId { get; set; }
        public int? TotalWorkingYears { get; set; }
        public int? YearsInCurrentRole { get; set; }
        public int? NumOfCompanies { get; set; }
        public string Promotions { get; set; }
    }
}
