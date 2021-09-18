using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Database.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
    }
}
