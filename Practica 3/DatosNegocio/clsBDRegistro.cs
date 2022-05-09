using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesNegocio;
using System.Data;
using System.Data.SqlClient;

namespace DatosNegocio
{
    public class clsBDRegistro
    {
        private CD_Conexion conexion = new CD_Conexion();
        public void Guardar(clsBERegistro objBERegistro)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "spEmpleado_Guardar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", objBERegistro.nombre);
            comando.Parameters.AddWithValue("@apellido", objBERegistro.apellido);
            
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Guardar(string nombre, string apellido)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "spEmpleado_Guardar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Modificar(clsBERegistro objBERegistro)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "spEmpleado_Actualizar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", objBERegistro.Id);
            comando.Parameters.AddWithValue("@nombre", objBERegistro.nombre);
            comando.Parameters.AddWithValue("@apellido", objBERegistro.apellido);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        } 

        public IDataReader ConsultarSaludEmpleado(int idEmpleado)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "spEmpleados_SaludxEmpreados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id",idEmpleado);
           return comando.ExecuteReader();
        }

        public int DevolverEntero(clsBERegistro objBERegistro, int edad)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "spEmpleado_DevolverEntero";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", objBERegistro.nombre);
            comando.Parameters.AddWithValue("@apellido", objBERegistro.apellido);
            comando.Parameters.AddWithValue("@edad", edad);

            int devolver = (int)comando.ExecuteScalar();
            //string devolver = comando.ExecuteScalar().ToString();
            return devolver;

        }

        public void guardarRegistrosLista(List<clsBERegistro> lista)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            foreach (clsBERegistro obj in lista)
            {
                comando.CommandText = "spEmpleado_Guardar";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", obj.nombre);
                comando.Parameters.AddWithValue("@apellido", obj.apellido);
                // Para el caso del ExecuteScalar, se debe declarar, asignar y devolver el parámetro, de lo contrario puede salir el error de "muchos parámetros en el procedimiento"
                int idEmpleado = (int)comando.ExecuteScalar(); 
                comando.Parameters.Clear(); // limpiar el command es muy importante para hacer nuevas consultas a la base de datos

                comando.CommandText = "spSaludEmpleados_Guardar";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Fecha", obj.fecha);
                comando.Parameters.AddWithValue("@EstadoSalud", obj.estadoSalud);
                comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            conexion.CerrarConexion();
        }

        public IDataReader Consultar(int id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "spEmpleado_Consultar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            return comando.ExecuteReader();
        }
       

        public void Eliminar(clsBERegistro objBERegistro)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "spEmpleado_Eliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", objBERegistro.Id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public IDataReader Buscar(string parametro)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "spEmpleado_Buscar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@parametro", parametro);
            return  comando.ExecuteReader();            
        }

        
    }
}
