using Microsoft.EntityFrameworkCore;
using StudentService.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Database
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SV80S7P;Initial Catalog=StudentMicroservice;Integrated Security=True");
        }
    }
}
