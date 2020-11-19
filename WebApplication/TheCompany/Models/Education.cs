using System;
using System.Collections.Generic;

namespace TheCompany.Models
{
    public partial class Education
    {
        public int EducationId { get; set; }
        public int? UserId { get; set; }
        public string EducationField { get; set; }
        public string EducationYears { get; set; }
    }
}
