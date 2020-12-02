using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlConsultasAPI.Models
{
    public class Consulta
    {
        public string Medico { get; set; }
        public string Paciente { get; set; }
        public DateTime fecha { get; set; }
    }
}
