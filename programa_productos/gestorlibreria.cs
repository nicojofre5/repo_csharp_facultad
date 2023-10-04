using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_productos
{
    public class gestorlibreria
    {
        public Venta ventaActual;
        private float totalRecaudado;

        public float Getrecaudacion()
        {
            return totalRecaudado;
        }
        public bool IniciarVenta()
        {
            if(ventaActual == null)
            {
                ventaActual = new Venta(); //genero instancia el objeto venta
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FinalizarVenta()
        {
            if (ventaActual != null) 
            {
                totalRecaudado += ventaActual.Subtotal;
                ventaActual = null;
            }
        }

    }
}
