using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesNegocio
{
   public class clsBEPersona: clsBELog /*clsBEPersona hereda de clsBELog: Clase Padre*/
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

    }
}
