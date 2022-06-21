using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace ServicioSOAP
{
    public partial class wfConsumir_SOAP : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnObjetoSOAP_Click(object sender, EventArgs e)
        {
            //SOAPPersona nombre dado a la referencia del servicio agregada
            SOAPPersona _objSoap = new SOAPPersona();
            string nombre = _objSoap.QuintoServicioSOAP().nombre;
            string apellido = _objSoap.QuintoServicioSOAP().apellido;
            Response.Write("<script>alert('" + "Mi nombre es: " + nombre  + ", Mi apellido es: " + apellido + "')</script>");

            //OTRA MANERA DE LLAMAR AL SERVICIO
            //SOAPPersonaSoapClient nombre del servicio remoto llamado. El sistema le agrega 'SoapClient' al final
            //ClienteSOAPPersona nombre dado a la referencia del servicio agregada
            //ClienteSOAPPersona.SOAPPersonaSoapClient cliente2 = new ClienteSOAPPersona.SOAPPersonaSoapClient();
        }

        protected void btnMatrizSOAP_Click(object sender, EventArgs e)
        {
            SOAPPersona _objSoap = new SOAPPersona();
            string [] matriz = _objSoap.CuartoServicioSOAP();
            Response.Write("<script>alert('" + "Mi nombre es: " + matriz[0] +  "')</script>");
        }

        protected void btnLogueo_Click(object sender, EventArgs e)
        {
            SOAPPersona _objSoap = new SOAPPersona();
            Persona entidad = new Persona();
            entidad.usuario = "Wilmar";
          entidad.usuario = "123456";

            Respuesta result = _objSoap.SegundoServicioSOAP(entidad );
            Response.Write("<script>alert('" + "Mi estado es: " + result.Estado + "')</script>");
        }

        protected void btnLista_Click(object sender, EventArgs e)
        {
            SOAPPersona _objSoap = new SOAPPersona();
            List<Acceso> Usuarios = new List<Acceso>(_objSoap.PrimerServicioSOAP());
            //Usuarios= _objSoap.PrimerServicioSOAP();
            
            dgvUsuarios.DataSource = Usuarios;
            dgvUsuarios.DataBind();

            //OTRA FORMA

            //DataTable tabla = new DataTable();
            //tabla.Columns.Add("usuario");
            //tabla.Columns.Add("contra");

            //foreach (var item in Usuarios)
            //{
            //    tabla.Rows.Add(item.usuario,item.contraseña);
            //}

            //dgvUsuarios.DataSource = tabla;
            //dgvUsuarios.DataBind();
        }
    }
}