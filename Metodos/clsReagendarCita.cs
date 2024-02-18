using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasEpsUNAULA
{
    public class clsReagendarCita
    {
        public int PacienteID { get; set; }
        public int CitaID { get; set; }
        public DateTime Fecha {  get; set; }
        public TimeSpan Hora { get; set; }

        public bool Reagenda()
        {
            return true;
        }
    }
}
