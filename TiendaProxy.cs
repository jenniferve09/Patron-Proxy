using System;
using System.Collections.Generic;
using System.Text;

namespace prueba4444
{
    public class TiendaProxy
    {
        //Creamos la interfaz con su metodo de petición
        public interface Contras
        {
            void Peticion(int pOpcion);
        }
        public class Proxycontras : Contras
        {
            private Contraseñas nombre;

            //Implementación del metodo "Petición" para llamar a nuestros procesos
            public void Peticion(int pOpcion)
            {
                //Creamos la instancia para nuestra contraseña 
                string password;
                password = Console.ReadLine();
                //Declaramos nuestra contraseña de seguridad como "contraseña"
                if (password == "contraseña")
                {
                    //Creamos la instancia
                    if (nombre == null)
                    {
 
                        nombre = new Contraseñas();
                    }
                    if (pOpcion == 1)
                        nombre.ContraseñasPriv();
                }
                else
                {
                    Console.WriteLine("Acceso Denegado, ingrese con una contraseña valida");
                }

            }

        }
        //CLASE PRIVADA PROTEGIDA POR PROXY
        private class Contraseñas
        {
            public void ContraseñasPriv()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Su codigo de entrada al sistema es:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*  0001");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t|--------------BIENVENIDO AL SISTEMA------------|\n");
                                       
            }
        
        }
    }
}
