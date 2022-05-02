using ApiDoctoresAWS.Data;
using ApiDoctoresAWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoctoresAWS.Repositories
{
    public class RepositoryDoctores
    {
        private DoctoresContext context;

        public RepositoryDoctores(DoctoresContext context)
        {
            this.context = context;
        }

        public List<Doctor> GetDoctores()
        {
            return this.context.Doctores.ToList();
        }

        public Doctor FindDoctor(string id)
        {
            return this.context.Doctores.Where(x => x.IdDoctor == id).FirstOrDefault();
        }

        public void CreateDoctor(string idDoctor, string idHospital, string apellido, string especialidad, int salario, string imagen)
        {
            Doctor doctor = new Doctor()
            {
                IdDoctor = idDoctor,
                IdHospital = idHospital,
                Apellido = apellido,
                Especialidad = especialidad,
                Salario = salario,
                Imagen = imagen
            };
            this.context.Doctores.Add(doctor);
            this.context.SaveChanges();
        }

        public void UpdateDoctor(string idDoctor, string idHospital, string apellido, string especialidad, int salario, string imagen)
        {
            Doctor doctor = FindDoctor(idDoctor);
            doctor.IdHospital = idHospital;
            doctor.Apellido = apellido;
            doctor.Especialidad = especialidad;
            doctor.Salario = salario;
            doctor.Imagen = imagen;
            this.context.SaveChanges();
        }

        public void DeleteDoctor(string idDoctor)
        {
            Doctor doctor = FindDoctor(idDoctor);
            this.context.Doctores.Remove(doctor);
            this.context.SaveChanges();
        }
    }
}
