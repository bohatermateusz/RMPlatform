using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RMPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        [EnableCors]
        public string Get()
        {
            List<Test> testValues = new List<Test>() { new Test { id = 1, title = "test title", body = "test body", userId = 11 } };
            var json = JsonConvert.SerializeObject(testValues, Formatting.Indented);
            return json;
        }
        // GET: api/Test
        // [HttpGet]
        //public IEnumerable<string> Get2()
        //{
            
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Test/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
