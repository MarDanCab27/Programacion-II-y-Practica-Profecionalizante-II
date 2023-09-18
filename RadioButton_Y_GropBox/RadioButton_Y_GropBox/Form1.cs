using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_Y_GropBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double res = 0, a = 0.0, b = 0.0;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            if (rbSuma.Checked == true) { res = a + b; }
            if (rbResta.Checked == true) { res = a - b; }
            if (rbMulti.Checked == true) { res = a * b; }
            if (rbDiv.Checked == true) { res = a / b; }
            lblResulatado.Text ="El resultado es: " + res;
        }
    }
}
