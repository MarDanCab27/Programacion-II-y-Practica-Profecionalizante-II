namespace Actividad7remake
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cbSituacionImp = new System.Windows.Forms.ComboBox();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btMostar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(62, 38);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // cbSituacionImp
            // 
            this.cbSituacionImp.FormattingEnabled = true;
            this.cbSituacionImp.Items.AddRange(new object[] {
            "Consumidor Final",
            "Monotributista",
            "Resp. Inscripto",
            "Excento",
            "No categorizado"});
            this.cbSituacionImp.Location = new System.Drawing.Point(326, 52);
            this.cbSituacionImp.Name = "cbSituacionImp";
            this.cbSituacionImp.Size = new System.Drawing.Size(121, 21);
            this.cbSituacionImp.TabIndex = 5;
            this.cbSituacionImp.SelectedIndexChanged += new System.EventHandler(this.cbSituacionImp_SelectedIndexChanged);
            this.cbSituacionImp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSituacionImp_KeyPress);
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(62, 84);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(100, 20);
            this.txtCuil.TabIndex = 6;
            this.txtCuil.TextChanged += new System.EventHandler(this.txtCuil_TextChanged);
            this.txtCuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuil_KeyPress);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(326, 12);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 7;
            this.txtSaldo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cuil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Impositiva";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(397, 339);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 11;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(405, 144);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(67, 24);
            this.btGuardar.TabIndex = 13;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            this.btGuardar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btGuardar_KeyPress);
            // 
            // btMostar
            // 
            this.btMostar.Location = new System.Drawing.Point(405, 174);
            this.btMostar.Name = "btMostar";
            this.btMostar.Size = new System.Drawing.Size(67, 24);
            this.btMostar.TabIndex = 14;
            this.btMostar.Text = "Mostrar";
            this.btMostar.UseVisualStyleBackColor = true;
            this.btMostar.Click += new System.EventHandler(this.btMostar_Click);
            this.btMostar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btMostar_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 374);
            this.Controls.Add(this.btMostar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.cbSituacionImp);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cbSituacionImp;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btMostar;
    }
}

