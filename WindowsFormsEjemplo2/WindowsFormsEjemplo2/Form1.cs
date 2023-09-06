using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEjemplo2
{
    public partial class Form1 : Form
    {
        public string[] usuario = new string[5];
        public string[] contrasena = new string[5];
        public int vacio;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < usuario.Length; i++)
            {

                if ((usuario[i] == Usuario_TextBox.Text) && (contrasena[i] == ingresoTxt.Text))
                {
                    PaginaBienvenido bienvenido = new PaginaBienvenido();
                    bienvenido.Visible = true;
                    this.Visible = false;

                }

            }
            Usuario_TextBox.Clear();
            ingresoTxt.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < usuario.Length; i++) {

                usuario[i] = "";
                contrasena[i] = "";
 
            }
            for (int i = 0; i < usuario.Length; i++) { 
                
                if ((usuario[i] == "" ) && (contrasena[i] == "" )){
                    vacio = i;
                    break;
                }

            }
            usuario[vacio]= Usuario_TextBox.Text;
            contrasena[vacio] = ingresoTxt.Text;
            MessageBox.Show("Te registraste con exito!!!");
            Usuario_TextBox.Clear();
            ingresoTxt.Clear();

        }

        private void Usuario_TextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
