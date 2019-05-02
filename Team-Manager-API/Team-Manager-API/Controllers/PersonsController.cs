using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamManagerApi.Model;
using TeamManagerApi.Services;

namespace TeamManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET: api/Persons
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.Get());
        }

        // GET: api/Persons/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string id)
        {
            return Ok(_personService.Get(id));
        }

        // POST: api/Persons
        [HttpPost]
        public void Post([FromBody] Person person)
        {
            _personService.Create(person);
        }

        // PUT: api/Persons/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Person person)
        {
            _personService.Update(id, person);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _personService.Remove(id);
        }
    }
}
