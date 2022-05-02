﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoctoresAWS.Models
{
    [Table("Doctor")]
    public class Doctor
    {
        [Key]
        [Column("DOCTOR_NO")]
        public string IdDoctor { get; set; }
        [Column("HOSPITAL_COD")]
        public string IdHospital { get; set; }
        [Column("APELLIDO")]
        public string Apellido { get; set; }
        [Column("ESPECIALIDAD")]
        public string Especialidad { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }
        [Column("IMAGEN")]
        public string Imagen { get; set; }
    }
}
