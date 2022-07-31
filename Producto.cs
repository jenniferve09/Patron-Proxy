using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Class
{
    internal class Producto
    {

        public String Id { set; get; }
        public String Modelo { set; get; }
        public String Color { set; get; }
        public String Talla { set; get; }
        public double Precio { set; get; }
        public int Stock { set; get; }
        public String Disponibilidad { set; get; }

        public Producto(string id, string modelo, string color, string talla, double precio, int stock, string disponibilidad)
        {
            this.Id = id;
            this.Modelo = modelo;
            this.Color = color;
            this.Talla = talla;
            this.Precio = precio;
            this.Stock = stock;
            this.Disponibilidad = disponibilidad;
        }

        public override string ToString()
        {
            return "Id:" + Id +
                   "\nModelo:" + Modelo +
                   "\nColor: " + Color +
                   "\nTalla: " + Talla +
                   "\nPrecio: " + Precio +
                   "\nCantidad: " + Stock +
                   "\nDisponibilidad: " + Disponibilidad;
        }

    }
}
