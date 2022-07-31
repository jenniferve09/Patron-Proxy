using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Class
{
    internal class Local
    {
        public String Id { get; set; }
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }

        public Local(string id, string nombre, string telefono, string direccion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }

        public override string ToString()
        {
            return "\t\t|------Datos de la tienda-----|" +
                   "\nNombre: " + Nombre +
                   "\nTelefono: " + Telefono +
                   "\nDirección: " + Direccion;
        }

    }
}
