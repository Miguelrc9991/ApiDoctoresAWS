using ApiDoctoresAWS.Models;
using ApiDoctoresAWS.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDoctoresAWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctoresController : ControllerBase
    {
        private RepositoryDoctores repo;

        public DoctoresController(RepositoryDoctores repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Doctor>> GetDoctores()
        {
            return this.repo.GetDoctores();
        }

        [HttpGet("{id}")]
        public ActionResult<Doctor> FindDoctor(string id)
        {
            return this.repo.FindDoctor(id);
        }

        [HttpPost]
        public ActionResult CreateDoctores(Doctor doctor)
        {
            this.repo.CreateDoctor(doctor.IdDoctor, doctor.IdHospital, doctor.Apellido, doctor.Especialidad, doctor.Salario, doctor.Imagen);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateDoctor(Doctor doctor)
        {
            this.repo.UpdateDoctor(doctor.IdDoctor, doctor.IdHospital, doctor.Apellido, doctor.Especialidad, doctor.Salario, doctor.Imagen);
            return Ok();
        }

        [HttpDelete("{idDoctor}")]
        public ActionResult DeleteDoctor(string idDoctor)
        {
            this.repo.DeleteDoctor(idDoctor);
            return Ok();
        }
    }
}
