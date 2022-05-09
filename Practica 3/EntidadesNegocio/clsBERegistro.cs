using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesNegocio
{
    public class clsBERegistro: clsBEPersona /*clsBERegistro hereda de clsBEPersona: Clase Padre*/
    {
        public int Id { get; set; }     
        public DateTime fecha { get; set; }
        public string estadoSalud{get;set;}
        public int Estrato { get; set; }
    }
}
