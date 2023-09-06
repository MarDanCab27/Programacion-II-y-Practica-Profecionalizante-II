using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construccion_de_appwinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            //MessageBox.Show("Bienvenido " + nombre + " este es tu primer furmulario de programacion");
            string mensaje = string.Format("Bienvenido " + nombre + " este es tu primer furmulario de programacion");
            Form2 Form2 = new Form2(mensaje);
            Form2.Visible = true;
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
