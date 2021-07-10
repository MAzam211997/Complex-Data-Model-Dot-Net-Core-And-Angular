using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.Entities.Entities;
using ComplexDataModelCoreAndAngular.Data;

namespace ComplexDataModelCoreAndAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseAssignmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CourseAssignmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CourseAssignments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseAssignment>>> GetCourseAssignments()
        {
            return await _context.CourseAssignments.ToListAsync();
        }

        // GET: api/CourseAssignments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CourseAssignment>> GetCourseAssignment(int id)
        {
            var courseAssignment = await _context.CourseAssignments.FindAsync(id);

            if (courseAssignment == null)
            {
                return NotFound();
            }

            return courseAssignment;
        }

        // PUT: api/CourseAssignments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourseAssignment(int id, CourseAssignment courseAssignment)
        {
            if (id != courseAssignment.CourseID)
            {
                return BadRequest();
            }

            _context.Entry(courseAssignment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseAssignmentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CourseAssignments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CourseAssignment>> PostCourseAssignment(CourseAssignment courseAssignment)
        {
            _context.CourseAssignments.Add(courseAssignment);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CourseAssignmentExists(courseAssignment.CourseID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCourseAssignment", new { id = courseAssignment.CourseID }, courseAssignment);
        }

        // DELETE: api/CourseAssignments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourseAssignment(int id)
        {
            var courseAssignment = await _context.CourseAssignments.FindAsync(id);
            if (courseAssignment == null)
            {
                return NotFound();
            }

            _context.CourseAssignments.Remove(courseAssignment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CourseAssignmentExists(int id)
        {
            return _context.CourseAssignments.Any(e => e.CourseID == id);
        }
    }
}
