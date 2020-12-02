using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlConsultasAPI.Controllers
{
    [Route("api/[controller]")]
    public class ConsultasController
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Consulta1", "Consulta2" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "consulta";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
