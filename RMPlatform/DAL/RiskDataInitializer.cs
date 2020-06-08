using RMPlatform.Models;
using System;
using System.Collections.Generic;

namespace RMPlatform.DAL
{
    public class RiskDataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RiskDataContext>
    {
        protected override void Seed(RiskDataContext context)
        {
            var students = new List<Employee>
            {
            new Employee{Name="Carson", Surname="Alexander", DataInputDate= DateTime.Parse("2005-09-01")},
            new Employee{Name="Meredith",Surname="Alonso",DataInputDate=DateTime.Parse("2002-09-01")},
            new Employee{Name="Arturo",Surname="Anand",DataInputDate=DateTime.Parse("2003-09-01")},
            new Employee{Name="Gytis",Surname="Barzdukas",DataInputDate=DateTime.Parse("2002-09-01")},
            new Employee{Name="Yan",Surname="Li",DataInputDate=DateTime.Parse("2002-09-01")},
            new Employee{Name="Peggy",Surname="Justice",DataInputDate=DateTime.Parse("2001-09-01")},
            new Employee{Name="Laura",Surname="Norman",DataInputDate=DateTime.Parse("2003-09-01")},
            new Employee{Name="Nino",Surname="Olivetto",DataInputDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
            var courses = new List<Department>
            {
            new Department{DepartmentID=1050, Name="Chemistry", Credits=3},
            new Department{DepartmentID=4022,Name="Microeconomics",Credits=3,},
            new Department{DepartmentID=4041,Name="Macroeconomics",Credits=3,},
            new Department{DepartmentID=1045,Name="Calculus",Credits=4,},
            new Department{DepartmentID=3141,Name="Trigonometry",Credits=4,},
            new Department{DepartmentID=2021,Name="Composition",Credits=3,},
            new Department{DepartmentID=2042,Name="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{EmployeeID=1, DepartmentID=1050, Grade=Grade.A},
            new Enrollment{EmployeeID=1,DepartmentID=4022,Grade=Grade.C},
            new Enrollment{EmployeeID=1,DepartmentID=4041,Grade=Grade.B},
            new Enrollment{EmployeeID=2,DepartmentID=1045,Grade=Grade.B},
            new Enrollment{EmployeeID=2,DepartmentID=3141,Grade=Grade.F},
            new Enrollment{EmployeeID=2,DepartmentID=2021,Grade=Grade.F},
            new Enrollment{EmployeeID=3,DepartmentID=1050},
            new Enrollment{EmployeeID=4,DepartmentID=1050,},
            new Enrollment{EmployeeID=4,DepartmentID=4022,Grade=Grade.F},
            new Enrollment{EmployeeID=5,DepartmentID=4041,Grade=Grade.C},
            new Enrollment{EmployeeID=6,DepartmentID=1045},
            new Enrollment{EmployeeID=7,DepartmentID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
