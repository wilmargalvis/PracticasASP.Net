using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesNegocio
{
   public class clsBELog /*clsBELog: Clase Padre (deja herencia a otras clases)*/
    {
      private DateTime fecharRegistro;
      public DateTime FecharRegistro 
        {
            get { 
                return fecharRegistro;
                    } 

            set { 
                fecharRegistro = System.DateTime.Now; 
                 } 
        }

       
    }
}
