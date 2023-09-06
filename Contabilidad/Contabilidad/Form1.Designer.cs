namespace Contabilidad
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.textInteresEX = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTasaIntereses = new System.Windows.Forms.Label();
            this.rbInterese1 = new System.Windows.Forms.RadioButton();
            this.rbInteres2 = new System.Windows.Forms.RadioButton();
            this.rbInteres3 = new System.Windows.Forms.RadioButton();
            this.lstResul = new System.Windows.Forms.ListBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(116, 81);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 0;
            this.txtMonto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(116, 12);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(399, 20);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpresa_KeyPress);
            // 
            // textInteresEX
            // 
            this.textInteresEX.Enabled = false;
            this.textInteresEX.Location = new System.Drawing.Point(415, 317);
            this.textInteresEX.Name = "textInteresEX";
            this.textInteresEX.Size = new System.Drawing.Size(100, 20);
            this.textInteresEX.TabIndex = 2;
            this.textInteresEX.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(415, 81);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 3;
            this.txtTiempo.Text = "2";
            this.txtTiempo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempo_KeyPress);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(4, 15);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(106, 13);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "Nombre de Empresa:";
            this.lblEmpresa.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(18, 84);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(92, 13);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto prestamo $";
            this.lblMonto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(335, 84);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(74, 13);
            this.lblTiempo.TabIndex = 6;
            this.lblTiempo.Text = "Tiempo (años)";
            // 
            // lblTasaIntereses
            // 
            this.lblTasaIntereses.AutoSize = true;
            this.lblTasaIntereses.Location = new System.Drawing.Point(75, 209);
            this.lblTasaIntereses.Name = "lblTasaIntereses";
            this.lblTasaIntereses.Size = new System.Drawing.Size(83, 13);
            this.lblTasaIntereses.TabIndex = 7;
            this.lblTasaIntereses.Text = "Tasa Intereses: ";
            // 
            // rbInterese1
            // 
            this.rbInterese1.AutoSize = true;
            this.rbInterese1.Checked = true;
            this.rbInterese1.Location = new System.Drawing.Point(25, 320);
            this.rbInterese1.Name = "rbInterese1";
            this.rbInterese1.Size = new System.Drawing.Size(45, 17);
            this.rbInterese1.TabIndex = 8;
            this.rbInterese1.TabStop = true;
            this.rbInterese1.Text = "12%";
            this.rbInterese1.UseVisualStyleBackColor = true;
            this.rbInterese1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.rbInterese1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbInterese1_KeyPress);
            // 
            // rbInteres2
            // 
            this.rbInteres2.AutoSize = true;
            this.rbInteres2.Location = new System.Drawing.Point(152, 320);
            this.rbInteres2.Name = "rbInteres2";
            this.rbInteres2.Size = new System.Drawing.Size(54, 17);
            this.rbInteres2.TabIndex = 9;
            this.rbInteres2.Text = "23.5%";
            this.rbInteres2.UseVisualStyleBackColor = true;
            this.rbInteres2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.rbInteres2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbInteres2_KeyPress);
            // 
            // rbInteres3
            // 
            this.rbInteres3.AutoSize = true;
            this.rbInteres3.Location = new System.Drawing.Point(288, 318);
            this.rbInteres3.Name = "rbInteres3";
            this.rbInteres3.Size = new System.Drawing.Size(88, 17);
            this.rbInteres3.TabIndex = 10;
            this.rbInteres3.Text = "Otro, indique:";
            this.rbInteres3.UseVisualStyleBackColor = true;
            this.rbInteres3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.rbInteres3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbInteres3_KeyPress);
            // 
            // lstResul
            // 
            this.lstResul.Enabled = false;
            this.lstResul.FormattingEnabled = true;
            this.lstResul.Location = new System.Drawing.Point(25, 365);
            this.lstResul.Name = "lstResul";
            this.lstResul.Size = new System.Drawing.Size(490, 95);
            this.lstResul.TabIndex = 11;
            this.lstResul.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(83, 546);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(123, 23);
            this.btnAnalisis.TabIndex = 12;
            this.btnAnalisis.Text = "Analisis Financiero";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(334, 546);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(106, 23);
            this.btnFin.TabIndex = 13;
            this.btnFin.Text = "Salir del programa";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 602);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.lstResul);
            this.Controls.Add(this.rbInteres3);
            this.Controls.Add(this.rbInteres2);
            this.Controls.Add(this.rbInterese1);
            this.Controls.Add(this.lblTasaIntereses);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.textInteresEX);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtMonto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox textInteresEX;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTasaIntereses;
        private System.Windows.Forms.RadioButton rbInterese1;
        private System.Windows.Forms.RadioButton rbInteres2;
        private System.Windows.Forms.RadioButton rbInteres3;
        private System.Windows.Forms.ListBox lstResul;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Button btnFin;
    }
}

