using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEstudiantes.Estudiantes;

namespace WebApiEstudiantes.Controllers
{

    [ApiController]
    [Route("api/Estudiantes")]
    public class EstudiantesController
    {
        public List<Estudiante> LstEstudiantes = new List<Estudiante> { new Estudiante() { Codigo = 2251217, Nombre = "Juan", ProgramaFormacion = "ADSI"} };

        [HttpGet]

        public ActionResult<List<Estudiante>> Get()
        {
            return LstEstudiantes;
        }

        [HttpPost]

        public ActionResult<List<Estudiante>> Post()
        {
            return LstEstudiantes;
        }

        [HttpDelete]
        [Route("{codigo}")]

        public Estudiante Delete(int Codigo)
        {
            var estudiante = LstEstudiantes.Find(Estudiante => Estudiante.Codigo == 2251217);
            LstEstudiantes.Remove(estudiante);

            return estudiante;
        }






    }
}
