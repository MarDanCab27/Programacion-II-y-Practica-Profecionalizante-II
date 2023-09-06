namespace WindowsFormsEjemplo2
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
            this.button_ing = new System.Windows.Forms.Button();
            this.button_reg = new System.Windows.Forms.Button();
            this.ingresoTxt = new System.Windows.Forms.TextBox();
            this.Usuario_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // button_ing
            // 
            this.button_ing.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ing.Location = new System.Drawing.Point(217, 277);
            this.button_ing.Name = "button_ing";
            this.button_ing.Size = new System.Drawing.Size(101, 43);
            this.button_ing.TabIndex = 1;
            this.button_ing.Text = "Ingresar";
            this.button_ing.UseVisualStyleBackColor = true;
            this.button_ing.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_reg
            // 
            this.button_reg.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reg.Location = new System.Drawing.Point(340, 277);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(101, 43);
            this.button_reg.TabIndex = 2;
            this.button_reg.Text = "Registrarse";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // ingresoTxt
            // 
            this.ingresoTxt.Location = new System.Drawing.Point(352, 134);
            this.ingresoTxt.Name = "ingresoTxt";
            this.ingresoTxt.PasswordChar = '*';
            this.ingresoTxt.Size = new System.Drawing.Size(100, 20);
            this.ingresoTxt.TabIndex = 3;
            this.ingresoTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Usuario_TextBox
            // 
            this.Usuario_TextBox.Location = new System.Drawing.Point(352, 55);
            this.Usuario_TextBox.Name = "Usuario_TextBox";
            this.Usuario_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Usuario_TextBox.TabIndex = 4;
            this.Usuario_TextBox.TextChanged += new System.EventHandler(this.Usuario_TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(458, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsEjemplo2.Properties.Resources.marcianitocienporcien;
            this.pictureBox1.Location = new System.Drawing.Point(-30, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 300);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usuario_TextBox);
            this.Controls.Add(this.ingresoTxt);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.button_ing);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ing;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.TextBox ingresoTxt;
        private System.Windows.Forms.TextBox Usuario_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

