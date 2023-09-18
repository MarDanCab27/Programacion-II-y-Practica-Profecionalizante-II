namespace Clase_10_com_entre_forms
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
            this.btnEnvio1 = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnvio2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnvio1
            // 
            this.btnEnvio1.Location = new System.Drawing.Point(190, 13);
            this.btnEnvio1.Name = "btnEnvio1";
            this.btnEnvio1.Size = new System.Drawing.Size(75, 23);
            this.btnEnvio1.TabIndex = 0;
            this.btnEnvio1.Text = "Envio1";
            this.btnEnvio1.UseVisualStyleBackColor = true;
            this.btnEnvio1.Click += new System.EventHandler(this.btnEnvio1_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(26, 15);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(100, 20);
            this.txtMensaje.TabIndex = 1;
            // 
            // btnEnvio2
            // 
            this.btnEnvio2.Location = new System.Drawing.Point(190, 60);
            this.btnEnvio2.Name = "btnEnvio2";
            this.btnEnvio2.Size = new System.Drawing.Size(75, 23);
            this.btnEnvio2.TabIndex = 2;
            this.btnEnvio2.Text = "Envio2";
            this.btnEnvio2.UseVisualStyleBackColor = true;
            this.btnEnvio2.Click += new System.EventHandler(this.btnEnvio2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEnvio2);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnEnvio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvio1;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnvio2;
    }
}

