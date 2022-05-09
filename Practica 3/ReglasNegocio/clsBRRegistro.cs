using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesNegocio;
using DatosNegocio;
using System.Data;
using System.Data.SqlClient;
using Interfaces;

namespace ReglasNegocio
{
    public class clsBRRegistro : IEmpleado
    {
        private readonly clsBDRegistro clsBDRegistro = new clsBDRegistro();

        public string _nombre { get; set; }
        public string _apellido { get; set; }

        //public clsBRRegistro()
        //{

        //}


        ///*CONSTRUCTOR*/
        //public clsBRRegistro(string nombre, string apellido)
        //{
        //    _nombre = nombre;
        //    _apellido = apellido;
        //}


        ///*CONSTRUCTOR*/
        //public clsBRRegistro(clsBERegistro objBERegistro)
        //{
        //    _nombre = objBERegistro.nombre;
        //    _apellido = objBERegistro.apellido;
        //}

        public void Guardar(clsBERegistro objBERegistro)
        {
            clsBDRegistro.Guardar(objBERegistro); // Lleva objeto
        }
        public void Guardar()
        {
            clsBDRegistro.Guardar(_nombre, _apellido);  // Lleva parametros
        }

        public void Modificar(clsBERegistro objBERegistro)
        {
            clsBDRegistro.Modificar(objBERegistro);
        }

        public void Eliminar(clsBERegistro objBERegistro)
        {
            clsBDRegistro.Eliminar(objBERegistro);
        }

        public IDataReader Buscar(string parametro) {
            return clsBDRegistro.Buscar(parametro);
        }

        public IDataReader Consultar(int id)
        {
            return clsBDRegistro.Consultar(id);
        }
        public DataTable ConsultarToTable(int id)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre");
            dt.Columns.Add("apellido");
            dt.Columns.Add("fecha");
            dt.Columns.Add("estadoSalud");
            IDataReader mreader= clsBDRegistro.Consultar(id);
            while (mreader.Read()) {

                dt.Rows.Add(mreader["nombre"].ToString(),
                    mreader["apellido"].ToString(),
                    //Convert.ToDateTime(mreader["fecha"].ToString()),
                    "",
                   "");//, mreader["EstadoSalud"].ToString());
            }
            mreader.Close();
            return dt;
        }

        public int DevolverEntero(clsBERegistro objBERegistro, int edad)
        {
            return clsBDRegistro.DevolverEntero(objBERegistro, edad);
        }

        public IDataReader ConsultarSaludEmpleado(int idEmpleado)
        {
            return clsBDRegistro.ConsultarSaludEmpleado(idEmpleado);
        }

        public void guardarRegistrosLista(List<clsBERegistro> lista)
        {
            clsBDRegistro.guardarRegistrosLista(lista);
        }

        public void Log()
        {
            throw new NotImplementedException();
        }
    }
}
