using System;
using System.Collections.Generic;

namespace OrganisationX.Models
{
    public partial class Education
    {
        public int EducationId { get; set; }
        public string EducationField { get; set; }
        public int? EducationYears { get; set; }
        public int? UserId { get; set; }
    }
}
