﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2(string textx)
        {
            InitializeComponent();
            label1.Text = textx;
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Close();
            Form1.Visible = true;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Marcelo\\Pictures\\petalos.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
