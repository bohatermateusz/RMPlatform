using System;
using System.Collections.Generic;

namespace RMPlatform.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTimeOffset DataInputDate { get; set; }

        public virtual ICollection<Enrollment> Departments { get; set; }
    }

  



    


}
