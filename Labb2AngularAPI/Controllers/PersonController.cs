using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Labb2AngularAPI.Models;

namespace Labb2AngularAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IBaseRepo<Person> _iBaseRepo;

        public PersonController(IBaseRepo<Person> iBaseRepo) => _iBaseRepo = iBaseRepo;



        // GET: api/Person
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetAllPersons() => Ok(await _iBaseRepo.GetAllAsync());

        // GET: api/Person/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            var person = await _iBaseRepo.GetByIdAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        // PUT: api/Person/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerson(Person person)
        {

            await _iBaseRepo.UpdateAsync(person);            

            return Ok();
        }

        // POST: api/Person
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Person>> PostPerson([FromBody] Person person)
        {
            await _iBaseRepo.AddAsync(person);
            return CreatedAtAction(nameof(GetPersonById), new { id = person.Id }, person);
        }

        // DELETE: api/Person/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            var person = await _iBaseRepo.GetByIdAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            await _iBaseRepo.DeleteAsync(person);

            return Ok();
        }

        
    }
}
