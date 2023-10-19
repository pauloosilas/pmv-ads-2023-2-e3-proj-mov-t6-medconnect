﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medconnect.API.Models
{
    public class Consulta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ConsultaId { get; set; }
        public DateTime DataConsulta { get; set; }  

    }
}
