using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_productos
{
    public class Producto
    {
        private int id;
        private int codigo;
        private int nombre;
        public string descripcion;
        private float precio;

        public int Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }



    }
}
