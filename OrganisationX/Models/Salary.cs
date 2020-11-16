using System;
using System.Collections.Generic;

namespace OrganisationX.Models
{
    public partial class Salary
    {
        public int SalaryId { get; set; }
        public string Overtime { get; set; }
        public string MonthlyIncome { get; set; }
        public string HourlyRate { get; set; }
        public int? UserId { get; set; }
    }
}
