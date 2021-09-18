using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Database;
using StudentService.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        DatabaseContext db;
        public StudentController()
        {
            db = new DatabaseContext();
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return db.Students.ToList();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return db.Students.Find(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public IActionResult Post([FromBody] Student st)
        {
            try
            {
                db.Students.Add(st);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, st);
            }
            catch (Exception exc)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exc);
            }
        }
    }
}
