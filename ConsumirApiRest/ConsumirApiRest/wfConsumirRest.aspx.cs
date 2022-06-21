using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace ConsumirApiRest
{
    public partial class wfConsumirRest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //agregar el paquete Nuget: Newtonsoft.Json

            if (!IsPostBack) {

                //Enviar datos en JSON al servicio API Rest
                EscribirData();

                //Consumir servicio API Rest
                HttpClient clienteHttp = new HttpClient();
                clienteHttp.BaseAddress = new Uri("https://localhost:44337/");
                var request = clienteHttp.GetAsync("api/Values/lista").Result;

                if (request.IsSuccessStatusCode) { // es el código 200 para 
                    var resulString = request.Content.ReadAsStringAsync().Result;
                    var listado = JsonConvert.DeserializeObject<List<Empleados>>(resulString);

                    dgvEmpleados.DataSource = listado;
                    dgvEmpleados.DataBind();
                }

                EscribirData();

                //DataTable tabla = new DataTable();
                //tabla.Columns.Add("id");
                //tabla.Columns.Add("Nombre");
                //tabla.Columns.Add("Apellido");
                //tabla.Rows.Add("1", "Wilmar", "Galvis");
                //tabla.Rows.Add("2", "María", "Jimenez");
                //dgvEmpleados.DataSource = tabla;
                //dgvEmpleados.DataBind();

                //clienteHttp.PostAsync();
                //clienteHttp.PutAsync();
                //clienteHttp.DeleteAsync();
            }

        }

        private void EscribirData()
        {
            List<data> data = new List<data> {
                new data(){producto="gaseosa",cantidad="2",precio="5000",tipo="postobon"},
                new data(){producto="gaseosa",cantidad="10",precio="2000",tipo="cocacola"},
                new data(){producto="gaseosa",cantidad="5",precio="10000",tipo="postobon"}

            };

            //var content = new FormUrlEncodedContent(new[]
            //{
            //    new KeyValuePair<string, string>("123", "nombre"),
            //    new KeyValuePair<string, string>("123", "apellido")
            //});
            persona obj = new persona();
            obj.nombre = "sebas";
            obj.apellido = "agudelo";

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            var datax = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("https://localhost:44337/");
            var request = clienteHttp.PostAsync("api/Values", datax).Result;

        }
        public class persona { 
          public string nombre { get; set; }
            public string apellido { get; set; }
        }


        public class data {
            public string producto { get; set; }
            public string cantidad { get; set; }
            public string precio { get; set; }
            public string tipo { get; set; }
        }

        protected void dgvEmpleados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                int id = int.Parse(dgvEmpleados.DataKeys[index].Value.ToString());
                lblMensaje.Text = id.ToString();
            }
        }
    }
}