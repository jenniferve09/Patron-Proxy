
using prueba4444;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Class;

namespace Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LA CONTRASEÑA PARA EL INGRESO ES contraseña
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t BIENVENIDO AL SISTEMA DE LA TIENDA FASHIONSTYLE \n");
            Console.WriteLine("Ingre su contraseña para continuar:");
            TiendaProxy.Contras proxyn = new TiendaProxy.Proxycontras();
            proxyn.Peticion(1);

            Local local = new Local("1", "RBlack", "0982340054", "Fashion Style");
            Producto producto1 = new Producto("1", "Mangas cortas", "Rojo", "M", 4.50, 3, "Disponible");
            Producto producto2 = new Producto("1", "Mangas largas", "Amarillo", "M", 5.00, 2, "Disponible");
            Cliente cliente1 = new Cliente("1", "Jose", "Chavez", "1728821082", "0986250734", "Jose@gmail.com", "Manta", "Leonidas Proaño");
            Empleado empleado1 = new Empleado("1", "Evelyn", "Valdez", "187239231", "0982348011", "Eve@gmail.com", "Manta", "EveVaL", "29433958EV");

            List<Producto> productos = new List<Producto>();
            List<Cliente> clientes = new List<Cliente>();
            List<Empleado> empleados = new List<Empleado>();
            List<Factura> facturas = new List<Factura>();

            clientes.Add(cliente1);
            empleados.Add(empleado1);
            productos.Add(producto1);
            productos.Add(producto2);

            for (int i = 1; i <= 3; i++)
            {
                foreach (Producto item in productos)
                {
                    if (item.Modelo.ToLower() == "mangas cortas" && item.Color.ToLower() == "rojo" && item.Stock > 0)
                    {
                        item.Stock = item.Stock - 1;
                        Factura factura = new Factura("1", 0.12, "13/06/2022", item, i);
                        facturas.Add(factura);
                    }
                }

            }

            Console.WriteLine("\t\t|--------------------FACTURA--------------------|\n" +
                 "\nNombre: " + local.Nombre + "" +
                 "\nTelefono: " + local.Telefono + "\n");

            foreach (Factura item in facturas)
            {
                Console.WriteLine(item.ToString());

            }
            Console.WriteLine("\n");
            Console.WriteLine(facturas[1].valorPagar());
            Console.ReadKey();


        }
    }
}
