using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEstudiantes.Estudiantes;

namespace WebApiEstudiantes
{
    public class ApplicationDbContent : DbContext
    {

        public ApplicationDbContent( DbContextOptions options) : base(options)
        {

        }
        public DbSet <Estudiante> Estudiantes { get; set; }
    }
}
