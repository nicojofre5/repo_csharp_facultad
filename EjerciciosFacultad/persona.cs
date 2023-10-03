using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EjerciciosFacultad
{
    internal class persona
    {

        public string nombre { get; set; }
        public string apellido { get; set; }

        public string mostrarNombre()
        {
            return "El nombre es: " + nombre + "\r\nEl apellido es:" + apellido;
        }
    }
}
