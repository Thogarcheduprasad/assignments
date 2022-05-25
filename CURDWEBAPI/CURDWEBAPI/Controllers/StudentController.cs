using CURDWEBAPI.Data;
using CURDWEBAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CURDWEBAPI.Controllers
{
    [Route("api/[Controller]")]
    public class StudentController : Controller
    {
        private Context _context;
        public StudentController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Student> Get()
        {
            return _context.students.ToList();

        }

        [HttpGet("{Id}")]
        public Student GetStudent(int Id)
        {
            var student = _context.students.Where(a => a.Id == Id).SingleOrDefault();
            return student;
        }

        [HttpPost]
        public IActionResult PostStudent([FromBody]Student student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid");

            _context.students.Add(student);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            var student = await _context.students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            _context.students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        
      








    }
}
