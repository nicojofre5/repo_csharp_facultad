using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_productos
{
    public class Venta
    {
        private float subtotal;
        private int id;
        private DateTime fecha = DateTime.Now;
        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
        }

        public void AgregarProducto(int cantidad, Producto objProducto)
        {
            subtotal+= (cantidad * objProducto.Precio);
        }
    }
}
