using System;
using System.Collections.Generic;

namespace TheCompany.Models
{
    public partial class Salary
    {
        public int EmployeeNum { get; set; }
        public decimal? OverTime { get; set; }
        public decimal? MonthlyIncome { get; set; }
        public decimal? HourlyRate { get; set; }
        public string UserId { get; set; }
    }
}
