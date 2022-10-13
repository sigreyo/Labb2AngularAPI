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
    public class DepartmentController : ControllerBase
    {
        private readonly IBaseRepo<Department> _iBaseRepo;

        public DepartmentController(IBaseRepo<Department> iBaseRepo) => _iBaseRepo = iBaseRepo;



        // GET: api/Department
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetAllDepartments() => Ok(await _iBaseRepo.GetAllAsync());

        // GET: api/Department/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartmentById(int id)
        {
            var Department = await _iBaseRepo.GetByIdAsync(id);

            if (Department == null)
            {
                return NotFound();
            }

            return Ok(Department);
        }

        // PUT: api/Department/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDepartment(Department Department)
        {

            await _iBaseRepo.UpdateAsync(Department);            

            return Ok();
        }

        // POST: api/Department
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Department>> PostDepartment([FromBody] Department Department)
        {
            await _iBaseRepo.AddAsync(Department);
            return CreatedAtAction(nameof(GetDepartmentById), new { id = Department.Id }, Department);
        }

        // DELETE: api/Department/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var Department = await _iBaseRepo.GetByIdAsync(id);
            if (Department == null)
            {
                return NotFound();
            }

            await _iBaseRepo.DeleteAsync(Department);

            return Ok();
        }

        
    }
}
