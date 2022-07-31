using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Class
{
    internal class Factura
    {

        Double subtotal, IVA, total;
        public String Id { set; get; }

        public Double Iva { set; get; }

        public String Fecha { set; get; }
        public Producto Producto { set; get; }
        public int Cantidad { set; get; }


        public Factura(string id, double iva, string fecha, Producto producto, int cantidad)
        {
            this.Id = id;
            this.Iva = iva;
            this.Fecha = fecha;
            this.Producto = producto;
            this.Cantidad = cantidad;
        }
        public Factura()
        {

        }

        public override string ToString()
        {
            subtotal = Producto.Precio * Cantidad;
            IVA = subtotal * Cantidad;
            total = subtotal + IVA;
            return "\nModelo: " + Producto.Modelo + " || Color: " + Producto.Color + " || Talla: " + Producto.Talla + "Precio por unidad: " + Producto.Precio + " || " + Cantidad;
        }

        public String valorPagar()
        {
            return "SUBTOTAL: " + subtotal +
                   "\nIVA: " + IVA +
                   "\nTOTAL: " + total;
        }
    }
}
