using EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEmpleado /*Interface*/
    {
        // Esto exige que la clase clsBRRegistro, tenga que implementar el siguiente método
        void Guardar(clsBERegistro objBERegistro);
        void Log();

    }
}
