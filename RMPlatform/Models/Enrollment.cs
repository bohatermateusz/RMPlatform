using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMPlatform.Models
{
    
    [Table("Enrollment")]
    public class Enrollment
    {
        
        public int EnrollmentID { get; set; }
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }
        public Department Department { get; set; }
    }


    
}
