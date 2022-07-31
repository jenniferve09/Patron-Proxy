using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Class
{
    internal class Empleado : Persona
    {
        public String User { set; get; }
        public String Password { set; get; }
        public Empleado(string id, string nombre, string apellido, string cedula, string telefono, string email, string ciudad, string user, string password) : base(id, nombre, apellido, cedula, telefono, email, ciudad)
        {
            this.User = user;
            this.Password = password;
        }




    }
}
