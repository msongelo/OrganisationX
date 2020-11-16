using System;
using System.Collections.Generic;

namespace OrganisationX.Models
{
    public partial class WorkRecord
    {
        public int WorkId { get; set; }
        public int? TotalWorkYears { get; set; }
        public int? YearsInCurrentRole { get; set; }
        public int? YearsInCurrentCom { get; set; }
        public int? NumOfCompanies { get; set; }
        public int? Promotions { get; set; }
    }
}
