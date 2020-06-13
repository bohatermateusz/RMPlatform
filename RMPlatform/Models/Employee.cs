﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMPlatform.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTimeOffset DataInputDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

  



    


}
