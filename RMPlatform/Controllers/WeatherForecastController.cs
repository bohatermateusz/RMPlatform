using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RMPlatform.Models;

namespace RMPlatform.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public IEnumerable<Department> Departments { get; set; }

        
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            Departments = GetDepartments();

            return Departments;

            //var departments = new Department[]
            //{
            //    new Department { DepartmentID = 1, Name = "BOR"},
            //    new Department { DepartmentID = 2, Name = "HR"},
            //    new Department { DepartmentID = 3, Name = "GIODO"}

            //};

            //context.Departments.AddRange(departments);
            //context.SaveChanges();


            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
        }

        private IEnumerable<Department> GetDepartments()
        {
            using (var context = new DAL.RiskDataContext())
            {
                Departments = context.Departments.ToList();
            }
            return Departments;
        }
    }
}

