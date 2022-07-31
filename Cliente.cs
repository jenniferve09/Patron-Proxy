using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Class
{
    internal class Cliente : Persona
    {
        public String Direccion { set; get; }
        public Cliente(string id, string nombre, string apellido, string cedula, string telefono, string email, string ciudad, string direccion) : base(id, nombre, apellido, cedula, telefono, email, ciudad)
        {
            this.Direccion = direccion;
        }

    }
}
