using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;

namespace RMPlatform.Models
{
    [Table("ConfidentialInformations")]
    public class ConfidentialInformations
    {
        public int ConfidentialInformationsID { get; set; }

        public string NameOfConfidentialInformation { get; set; }

        [Range(1, 10, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int RiskLevel { get; set; }
        [Range(1, 10, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Impact { get; set; }

        public string Description { get; set; }

        public ICollection<Enrollment> Enrollments { get;set;}
    }
}
