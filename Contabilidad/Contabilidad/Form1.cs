using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public partial class Form1 : Form
    {
        private double tasaI;
        public static Boolean isNumeric(string valor) 
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tasaI = 0.235;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tasaI = 0.12;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInteres3.Checked == true)
            {

                textInteresEX.Enabled = true;
                textInteresEX.Focus();
            }
            else {

                textInteresEX.Text = "0";
                textInteresEX.Enabled = false;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            string nombreEmpresa;
            double montoInicial = 0, montoFinal = 0;
            int tiempo;
            nombreEmpresa = txtEmpresa.Text;
            nombreEmpresa = nombreEmpresa.Trim();
            if (nombreEmpresa.Length == 0) {

                MessageBox.Show("Debe indicar Nombre de la empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Focus();
            }

            if (!(isNumeric(txtMonto.Text)))
            {

                MessageBox.Show("Valor monto incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {

                montoInicial = Convert.ToDouble(txtMonto.Text);
                if (!(montoInicial > 0))
                {

                    MessageBox.Show("Valor Monto no puede ser negativo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonto.Focus();
                    return;
                }
            }
            tiempo = Convert.ToInt32(txtTiempo.Text);
            textInteresEX.Text = textInteresEX.Text.Trim();

            if (rbInteres3.Checked == true)
            {
                if (textInteresEX.Text.Length > 0) {

                    if (!(isNumeric(textInteresEX.Text) == true))
                    {
                        MessageBox.Show("Tasa intereses incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textInteresEX.Text = "0";
                        textInteresEX.Focus();
                        return;
                    }
                    else
                    {

                        tasaI = Convert.ToDouble(textInteresEX.Text);

                    }
                }else {

                MessageBox.Show("Aun no ha inicado tasas de interes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textInteresEX.Focus();
                return;
            }
            

            }
            montoFinal = (1 + tasaI);
            montoFinal = montoInicial + (Math.Pow(montoFinal,tiempo));
            tasaI *= 100;
            lstResul.Items.Clear();
            lstResul.Items.Add("Empresa: " + txtEmpresa.Text);
            lstResul.Items.Add("Monto: $" + montoInicial + ", tasa anual: " + tasaI);
            lstResul.Items.Add("Monto a pgar: $" + montoFinal);
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                txtTiempo.Focus();
            }
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                txtMonto.Focus();
            }
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { rbInterese1.Focus(); }
        }

        private void rbInterese1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { rbInteres2.Focus(); }

        }

        private void rbInteres2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { rbInteres3.Focus(); }

        }

        private void rbInteres3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { btnAnalisis.Focus(); }

        }

    }
}
