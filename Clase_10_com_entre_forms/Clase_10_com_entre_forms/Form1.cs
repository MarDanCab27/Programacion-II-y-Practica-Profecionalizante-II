using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_10_com_entre_forms
{
    public partial class Form1 : Form
    {
        Form2 miForma2 = new Form2("");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEnvio1_Click(object sender, EventArgs e)
        {
            miForma2.Comentario = "suerte en el trabajo";
            miForma2.ShowDialog();
        }

        private void btnEnvio2_Click(object sender, EventArgs e)
        {
            miForma2.Comentario = txtMensaje.Text;
            miForma2.Show();
        }
    }
}
