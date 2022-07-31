using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Class
{
    internal class Persona
    {
        public String Id { set; get; }
        public String Nombre { set; get; }
        public String Apellido { set; get; }
        public String Cedula { set; get; }
        public String Telefono { set; get; }
        public String Email { set; get; }
        public String Ciudad { set; get; }

        public Persona(string id, string nombre, string apellido, string cedula, string telefono, string email, string ciudad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Telefono = telefono;
            this.Email = email;
            this.Ciudad = ciudad;
        }
        public Persona()
        {

        }

        public override string ToString()
        {
            return "Nombre: " + Nombre +
                   "\nApellido: " + Apellido +
                   "\nCedula: " + Telefono +
                   "\nTelefono: " + Telefono +
                   "\nEmail:" + Email +
                   "\nCiudad:" + Ciudad;
        }
    }
}