using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad7remake
{
    public partial class Form1 : Form
    {
        public string[,] mat = new string[3, 5];
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCuil_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSituacionImp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < mat.GetLength(0); i++) {
                if (cbSituacionImp.SelectedIndex == 0)
                {

                    if (txtNombre.Text == "") {

                        txtNombre.BackColor = Color.Bisque;

                    }else
                        if ()

                }
            }

        }

        private void btMostar_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13){ txtApellido.Focus(); }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { txtCuil.Focus(); }
           
        }

        private void txtCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { txtSaldo.Focus(); }
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { cbSituacionImp.Focus(); }
        }

        private void cbSituacionImp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { btGuardar.Focus(); }
        }
        
        private void btGuardar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { btMostar.Focus(); }
        }

        private void btMostar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { btSalir.Focus(); }
        }
    }
}
