namespace Matriz_interfaz_grafica
{
    partial class Formulario
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
            this.gpInformacion = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.cbTipoInfo = new System.Windows.Forms.ComboBox();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbTipoInfo = new System.Windows.Forms.Label();
            this.lbDigInfo = new System.Windows.Forms.Label();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btPromedio = new System.Windows.Forms.Button();
            this.brMostrar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.gpInformacion.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            this.gbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpInformacion
            // 
            this.gpInformacion.Controls.Add(this.txtEdad);
            this.gpInformacion.Controls.Add(this.txtInfo);
            this.gpInformacion.Controls.Add(this.cbTipoInfo);
            this.gpInformacion.Controls.Add(this.lbEdad);
            this.gpInformacion.Controls.Add(this.lbTipoInfo);
            this.gpInformacion.Controls.Add(this.lbDigInfo);
            this.gpInformacion.Location = new System.Drawing.Point(56, 47);
            this.gpInformacion.Name = "gpInformacion";
            this.gpInformacion.Size = new System.Drawing.Size(277, 160);
            this.gpInformacion.TabIndex = 0;
            this.gpInformacion.TabStop = false;
            this.gpInformacion.Text = "Informacion";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(122, 120);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 8;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(122, 70);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(100, 20);
            this.txtInfo.TabIndex = 7;
            this.txtInfo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInfo_KeyPress);
            // 
            // cbTipoInfo
            // 
            this.cbTipoInfo.FormattingEnabled = true;
            this.cbTipoInfo.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbTipoInfo.Location = new System.Drawing.Point(122, 30);
            this.cbTipoInfo.Name = "cbTipoInfo";
            this.cbTipoInfo.Size = new System.Drawing.Size(121, 21);
            this.cbTipoInfo.TabIndex = 6;
            this.cbTipoInfo.SelectedIndexChanged += new System.EventHandler(this.cbTipoInfo_SelectedIndexChanged);
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(6, 120);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(32, 13);
            this.lbEdad.TabIndex = 5;
            this.lbEdad.Text = "Edad";
            // 
            // lbTipoInfo
            // 
            this.lbTipoInfo.AutoSize = true;
            this.lbTipoInfo.Location = new System.Drawing.Point(6, 30);
            this.lbTipoInfo.Name = "lbTipoInfo";
            this.lbTipoInfo.Size = new System.Drawing.Size(100, 13);
            this.lbTipoInfo.TabIndex = 3;
            this.lbTipoInfo.Text = "Tipo de informacion";
            // 
            // lbDigInfo
            // 
            this.lbDigInfo.AutoSize = true;
            this.lbDigInfo.Location = new System.Drawing.Point(6, 73);
            this.lbDigInfo.Name = "lbDigInfo";
            this.lbDigInfo.Size = new System.Drawing.Size(92, 13);
            this.lbDigInfo.TabIndex = 4;
            this.lbDigInfo.Text = "Digite Informacion";
            // 
            // gbMatriz
            // 
            this.gbMatriz.Controls.Add(this.btSalir);
            this.gbMatriz.Controls.Add(this.btAgregar);
            this.gbMatriz.Controls.Add(this.btPromedio);
            this.gbMatriz.Controls.Add(this.brMostrar);
            this.gbMatriz.Controls.Add(this.btLimpiar);
            this.gbMatriz.Location = new System.Drawing.Point(443, 47);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Size = new System.Drawing.Size(283, 160);
            this.gbMatriz.TabIndex = 1;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Matriz";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(184, 70);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 13;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(6, 30);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 9;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btPromedio
            // 
            this.btPromedio.Location = new System.Drawing.Point(184, 30);
            this.btPromedio.Name = "btPromedio";
            this.btPromedio.Size = new System.Drawing.Size(75, 23);
            this.btPromedio.TabIndex = 12;
            this.btPromedio.Text = "Promedio";
            this.btPromedio.UseVisualStyleBackColor = true;
            this.btPromedio.Click += new System.EventHandler(this.btPromedio_Click);
            // 
            // brMostrar
            // 
            this.brMostrar.Location = new System.Drawing.Point(6, 70);
            this.brMostrar.Name = "brMostrar";
            this.brMostrar.Size = new System.Drawing.Size(75, 23);
            this.brMostrar.TabIndex = 10;
            this.brMostrar.Text = "Mostrar";
            this.brMostrar.UseVisualStyleBackColor = true;
            this.brMostrar.Click += new System.EventHandler(this.brMostrar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(6, 115);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 11;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.dgDatos);
            this.gbMantenimiento.Location = new System.Drawing.Point(56, 324);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(670, 146);
            this.gbMantenimiento.TabIndex = 2;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Mantenimientos";
            // 
            // dgDatos
            // 
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(9, 19);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.Size = new System.Drawing.Size(655, 121);
            this.dgDatos.TabIndex = 3;
            this.dgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDatos_CellContentClick);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.gpInformacion);
            this.Name = "Formulario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpInformacion.ResumeLayout(false);
            this.gpInformacion.PerformLayout();
            this.gbMatriz.ResumeLayout(false);
            this.gbMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpInformacion;
        private System.Windows.Forms.GroupBox gbMatriz;
        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.Label lbTipoInfo;
        private System.Windows.Forms.Label lbDigInfo;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.ComboBox cbTipoInfo;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btPromedio;
        private System.Windows.Forms.Button brMostrar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.DataGridView dgDatos;
    }
}

