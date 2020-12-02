using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlConsultasAPI.Data.Entities
{
    public class ConsultaEntity
    {
        public string Medico { get; set; }
        public string Paciente { get; set; }
        public DateTime fecha { get; set; }
    }
}
