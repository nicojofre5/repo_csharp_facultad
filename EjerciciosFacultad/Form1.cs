using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosFacultad
{
    public partial class Form1 : Form
    {
        internal persona personaObj;
        public Form1()
        {
            InitializeComponent();
            personaObj= new persona();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personaObj.nombre = textBox1.Text;
            personaObj.apellido = textBox2.Text;
            MessageBox.Show("Ha sido asignado el nombre y apellido");
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personaObj.mostrarNombre());
        }
    }
}
