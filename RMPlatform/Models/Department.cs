using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMPlatform.Models
{
    [Table("Department")]
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }
        public string Name { get; set; }

        public  ICollection<Enrollment> Enrollments { get; set; }
    }
}
