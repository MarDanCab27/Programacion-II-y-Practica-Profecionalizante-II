namespace Clase_10_com_entre_forms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEnvio1 = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnvio1
            // 
            this.lblEnvio1.AutoSize = true;
            this.lblEnvio1.Location = new System.Drawing.Point(13, 24);
            this.lblEnvio1.Name = "lblEnvio1";
            this.lblEnvio1.Size = new System.Drawing.Size(35, 13);
            this.lblEnvio1.TabIndex = 0;
            this.lblEnvio1.Text = "label1";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(16, 49);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(35, 13);
            this.lblComentario.TabIndex = 1;
            this.lblComentario.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 74);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.lblEnvio1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnvio1;
        private System.Windows.Forms.Label lblComentario;
    }
}