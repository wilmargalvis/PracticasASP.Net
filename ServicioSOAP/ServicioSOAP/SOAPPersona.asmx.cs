using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicioSOAP
{
    /// <summary>
    /// Descripción breve de SOAPPersona
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SOAPPersona : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Acceso> PrimerServicioSOAP()
        {
            List<Acceso> Usuarios = new List<Acceso>{
                        new Acceso(){usuario="Wilmar",contraseña="123" },
                        new Acceso(){usuario="sebas",contraseña="456" },
                        new Acceso(){usuario="maria",contraseña="789" }
                        };

            return Usuarios;
        }

        [WebMethod]
        public Respuesta SegundoServicioSOAP(Persona entidad)
        {

            Respuesta respuesta = new Respuesta();

            if (entidad.usuario == "Wilmar" && entidad.contraseña == "123456") {
                respuesta.Estado = "Autorizado";
               
            }
            else{
                respuesta.Estado = "No Autorizado";
            }
            return respuesta;
        }


        [WebMethod]
        public string [] CuartoServicioSOAP(String nombre="Wilmar", string apellido="Galvis")
        {
            //string[] datos = new string[2] {nombre, apellido };
            string [] datos=new string[2];
            datos[0] = nombre;
            datos[1] = apellido;
            return datos;
        }

        [WebMethod]
        public Persona QuintoServicioSOAP()
        {
            Persona _objPersona = new Persona();
            _objPersona.nombre = "Wilmar Alexander";
            _objPersona.apellido = "Galvis Arango";
            return _objPersona;
        }
    }

    public class Persona:Acceso
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

        public List<string> lista { get; set; }
    }
    public class Respuesta { 
      public string Estado { get; set; }
    }

    public class Acceso 
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string datos { get; set; }
    }
}
