using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Domain.Entidades;
using Library.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;

        public PersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        // GET: api/<PersonaController>
        [HttpGet]
        public object Get()
        {
            var var = _personaService.GetAll();
            return var;
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
            var var = _personaService.GetById(id);
            return var;
        }

        // POST api/<PersonaController>
        [HttpPost]
        public IActionResult Post([FromBody] Persona value)
        {
            _personaService.Add(value);
            return Ok();
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
