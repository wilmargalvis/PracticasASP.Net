using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesNegocio;
using ReglasNegocio;

using System.Data;
using System.Data.SqlClient;
using Interfaces;

namespace Practica_3
{
    public partial class wfRegistro : System.Web.UI.Page
    {

        /*TEMAS A ESTUDIAR  POLIMORFISMO */
        /*CLASES  ABSTRACTAS*/

        clsBERegistro _objBERegistro =new clsBERegistro();
        clsBRRegistro _ObjBRRegistro = new clsBRRegistro();
        private readonly IEmpleado _ObjIRegistro = new clsBRRegistro(); //Acceder a los métodos de la interfaz(IEmpleado) de tipo  clase(clsBRRegistro)

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                llenardatos();

                //ConsultarConFor();

                /*1. Guardar*/
                //Guardar(_objBERegistro);

                /*2. Buscar*/
                Buscar("mar"); // Nombres que terminen por mar

                /*3. Eliminar*/
                _objBERegistro.Id = 1;
                //Eliminar(_objBERegistro);

                /*4. Consultar*/ //Buscar un solo registro
                //Consultar(1);

                /*5. Modificar*/
                _objBERegistro.Id=2;
                //Modificar();

                /*6.Guardar y devolver parámetro*/
                //DevolverEntero(_objBERegistro);

                /*4. Consultar iner join*/
                //ConsultarEstadoSaludEmpleados(2);

                //5.Guardar listado empleados en varias tbl relacionadas
                //guardarRegistrosLista();



            }
        }

        private void ConsultarEstadoSaludEmpleados(int idEmpleado)
        {
            List<clsBERegistro> lista = new List<clsBERegistro>(); 
            IDataReader ConsultarSaludEmpleado = _ObjBRRegistro.ConsultarSaludEmpleado(idEmpleado);

            while (ConsultarSaludEmpleado.Read()) {
                _objBERegistro.nombre = ConsultarSaludEmpleado["nombre"].ToString();
                _objBERegistro.apellido = ConsultarSaludEmpleado["apellido"].ToString();
                _objBERegistro.fecha = Convert.ToDateTime(ConsultarSaludEmpleado["fecha"].ToString());
                _objBERegistro.estadoSalud = ConsultarSaludEmpleado["EstadoSalud"].ToString();
                lista.Add(_objBERegistro);
            }

        }


        private void guardarRegistrosLista()
        {
            //Agregar muchos objetos a la lista de tipo clase clsBERegistro
            List<clsBERegistro> lista = new List<clsBERegistro>
                {
                    new clsBERegistro(){ nombre = "Lili", apellido="Jimenez", fecha= Convert.ToDateTime("01/05/2022"), estadoSalud="Malestar general",Estrato=2 },
                    new clsBERegistro(){ nombre = "Veronica", apellido="Jimenez", fecha= Convert.ToDateTime("02/05/2022"), estadoSalud="Gripe",Estrato=1},
                    new clsBERegistro(){ nombre = "Rosita", apellido="Jimenez", fecha= new DateTime(2022, 05, 03), estadoSalud="Aliviado",Estrato=3 }
                };
            
            //Agregar un solo objeto a la lista de tipo clase clsBERegistro
            clsBERegistro obj = new clsBERegistro();
            obj.nombre= "Dario";
            obj.apellido = "Jimenez";
            obj.fecha = Convert.ToDateTime("04/05/2022");
            obj.estadoSalud = "Estable";
            obj.Estrato =2;
            lista.Add(obj);

            _ObjBRRegistro.guardarRegistrosLista(lista);

        }

        private void DevolverEntero(clsBERegistro objBERegistro)
        {
            int edad = 37;
            int nacimiento = _ObjBRRegistro.DevolverEntero(objBERegistro, edad);
        }

        private void llenardatos()
        {
            _objBERegistro.nombre = "Sebas";
            _objBERegistro.apellido = "agudelo";
            _objBERegistro.Estrato = (int)EnumeradorEstrato.Estrato1;
        }

        /// <summary>
        /// Se envía el id como parámetro para encontrar un empleado concreto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private DataTable Consultar(int id) {

            IDataReader readerEmpleados = _ObjBRRegistro.Consultar(id); // Recupero en IDataReader

            while (readerEmpleados.Read())
            {

                _objBERegistro.apellido = readerEmpleados.GetString(0);
                _objBERegistro.nombre = readerEmpleados.GetString(1);
                //  obj.nombre = readerEmpleados["nombre"].ToString();             
            }
            readerEmpleados.Close();


            DataTable dt = _ObjBRRegistro.ConsultarToTable(id); // Recupero en DataTable
            return dt;

        }


        private void ConsultarConFor() {

            DataTable dtRegistros = Consultar(2);

            for (int i = 0; i < dtRegistros.Rows.Count; i++)
            {
                string nombre = dtRegistros.Rows[i]["nombre"].ToString();
                string apellido = dtRegistros.Rows[i]["apellido"].ToString();



                /*SWITCH*/
                string resultado;
                switch (nombre)
                {
                    case "Sebastian":
                        resultado = "SI";
                        break;

                    case "Wilmar":
                        resultado = "No";
                        break;

                    default:
                        resultado = "Ninguno";
                        break;
                              
                }
            }

                foreach (DataRow item in dtRegistros.Rows)
                    {
                        string nombreDatatable = item["nombre"].ToString();
                        string apellidoDatatable = item["nombre"].ToString();

                    }
        
        }

 
        private void Eliminar(clsBERegistro objBERegistro)
        {

            _ObjBRRegistro.Eliminar(objBERegistro);
        }

        public void Buscar(string parametro) {

            List<clsBERegistro> lista = new List<clsBERegistro>();/*Lista Tipo Clase*/
            List<string> listaString = new List<string>();/*Lista String*/
            List<int> listaInt = new List<int>();/*Lista iNT*/

            IDataReader readerEmpleados = _ObjBRRegistro.Buscar(parametro);

            //CONVERTIR a DATATABLE, para asignar a gridview. El IDatareader tambien se asigna directo al Gridview
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nombre");
            dt.Columns.Add("apellido");
            while (readerEmpleados.Read())
            {
                //ddlNombres.Items.Add(readerEmpleados["nombre"].ToString()); //Otra manera de cargar en el ddlnombres
                dt.Rows.Add(readerEmpleados["id"].ToString(), 
                            readerEmpleados["nombre"].ToString(),
                            readerEmpleados["apellido"].ToString());
            }

            //LLENAR DROPDOWNLIST CON IDATAREADER

            //Tambien se puede llenar directo con el IDataReader de readerEmpleados, 
            //A continuación se llenará con con el Datatable
            ddlNombres.DataSource = dt;
            ddlNombres.DataValueField = "id";
            ddlNombres.DataTextField = "nombre";
            ddlNombres.DataBind();
            ddlNombres.Items.Insert(0, new ListItem("-- SELECCIONE EL NOMBRE --", "0"));
            readerEmpleados.Dispose();
            readerEmpleados.Close();

            //LLENAR GRIDVIEW CON IDATAREADER
            IDataReader readerEmpleados2 = _ObjBRRegistro.Buscar(parametro);
            gvUsuarios.DataSource = readerEmpleados2;
            gvUsuarios.DataBind();
            readerEmpleados2.Dispose();
            readerEmpleados2.Close();


            //LLENAR OBJETO LISTA
            IDataReader readerEmpleados3 = _ObjBRRegistro.Buscar(parametro);
            while (readerEmpleados3.Read())
            {
                clsBERegistro objBERegistro = new clsBERegistro(); //Se debe instanciar dentro del ciclo para que se libere la memoria y no se escriba el último registro en toda la lista
                objBERegistro.Id = readerEmpleados3.GetInt32(2);
                objBERegistro.nombre = readerEmpleados3.GetString(0);
                objBERegistro.apellido = readerEmpleados3.GetString(1);
                //objBERegistro.nombre = readerEmpleados["nombre"].ToString();
                lista.Add(objBERegistro);

            }
            readerEmpleados3.Dispose();
            readerEmpleados3.Close();

        }

        protected void ddlNombres_Change(object sender, EventArgs e) {
        
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="objBERegistro"></param>
        private void Guardar(clsBERegistro objBERegistro)
        {
            
            clsBRSaludEmpleado _ObjBRSalud= new clsBRSaludEmpleado();


            _ObjBRRegistro.Guardar(objBERegistro); //Sobrecarga de métodos en la clase destino. Envía objeto
            _ObjBRRegistro.Guardar(); //Sobrecarga de métodos en la clase destino. No envia parámetros


            _ObjIRegistro.Guardar(objBERegistro);/*GUARDAR CON LA INTERFAZ*/
            _ObjBRSalud.Guardar();/*POLIMOSFISMO.  El mismo método en otra clase*/
            Utilidades.cambiarMayuscula(objBERegistro.apellido); // Acceder a clase static (no requiere instanciarse)

            //clsBRRegistro _ObjBRRegistro = new clsBRRegistro(objBERegistro);/*CONSTRUCTOR*/


        }
        private void Modificar()
        {
            llenardatos();
            _ObjBRRegistro.Modificar(_objBERegistro);
        }

    }
}