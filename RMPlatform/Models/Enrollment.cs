using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMPlatform.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    
    [Table("Enrollment")]
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Employee Employee { get; set; }
    }


    
}
