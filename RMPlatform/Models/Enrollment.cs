using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMPlatform.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int DepartmentID { get; set; }
        public int EmployeeID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Employee Employee { get; set; }
    }


    
}
