using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total=0;
            if (chkTeclado.Checked == true) { total += 15; } 
            if (chkMouse.Checked == true) { total += 20; }
            if (chkMonior.Checked == true) { total += 250; }
            MessageBox.Show("El total es $" + total, "Total!");
        }

        private void chkTeclado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTeclado.Checked == true)
            {
                lblMensaje.Text = "Teclado";

            }
            else lblMensaje.Text = "";
        }

        private void chkMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMouse.Checked == true)
            {
                lblMensaje.Text = "Mouse";
            }
            else lblMensaje.Text = "";
        }

        private void chkMonior_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonior.Checked == true) {
                lblMensaje.Text = "Monitor";
            }
        }
    }
}
