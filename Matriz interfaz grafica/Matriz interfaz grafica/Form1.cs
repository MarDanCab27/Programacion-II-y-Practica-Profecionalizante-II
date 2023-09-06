using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_interfaz_grafica
{
    public partial class Formulario : Form
    {
        string[,] matriz = new string[3, 3];
        public int fila1, colum1, fila2, colum2, fila3, colum3, countergen, i;
        public static bool IsNumeric(string valor) {
            int result; return int.TryParse(valor, out result);
        }
        public Formulario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            colum1 = 0;
            colum2 = 1;
            colum3 = 2;
            if (cbTipoInfo.SelectedIndex == 0) {
                if (txtInfo.Text == "")
                {
                    txtInfo.BackColor = Color.Bisque;
                }
                else {
                    if (fila1 < 3)
                    {
                        matriz[fila1, colum1] = txtInfo.Text;
                        fila1 += 1;
                        MessageBox.Show("Nombre ingresado exitosamente", "", MessageBoxButtons.OK);
                        txtInfo.Clear();

                    }
                    else { MessageBox.Show("No se pueden agregar mas nombres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
            }else
                if (cbTipoInfo.SelectedIndex == 1)
                {
                    if (txtInfo.Text == "")
                    {
                        txtInfo.BackColor = Color.Bisque;
                    }
                    else
                        if (fila2 < 3)
                        {
                            matriz[fila2, colum2] = txtInfo.Text;
                            fila2 += 1;
                            MessageBox.Show("Apellido ingresado exitosamente");
                            txtInfo.Clear();
                        }
                        else { MessageBox.Show("No se pueden agregar mas apellidos"); }
                }
                else { MessageBox.Show("Seleccione una opcion"); }
            if (IsNumeric(txtEdad.Text) == true)
            {
                if (fila3 < 3)
                {
                    matriz[fila3, colum3] = txtEdad.Text;
                    fila3 += 1;
                    txtEdad.Clear();
                    countergen += 1;
                }
                else { MessageBox.Show("No se pueden cargar mas edades"); }
            }
            else { txtEdad.BackColor = Color.Beige; }
        }

        private void brMostrar_Click(object sender, EventArgs e)
        {
            //limpiamos grilla
            dgDatos.Columns.Clear();
            //creando columnas
            dgDatos.ColumnCount = 3;
            dgDatos.Columns[0].Name = "Nombre";
            dgDatos.Columns[1].Name = "Apellido";
            dgDatos.Columns[0].Name = "Edad";

            dgDatos.Rows.Add();
            dgDatos.Rows.Add();
            //agregamos datos a grilla

            //Mostramos nombre
            dgDatos.Rows[0].Cells[0].Value = matriz[0, 0];
            dgDatos.Rows[0].Cells[1].Value = matriz[0, 1];
            dgDatos.Rows[0].Cells[2].Value = matriz[0, 2];

            //Mostramos apellidos
            dgDatos.Rows[1].Cells[0].Value = matriz[1, 0];
            dgDatos.Rows[1].Cells[1].Value = matriz[1, 1];
            dgDatos.Rows[1].Cells[2].Value = matriz[1, 2];

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtEdad.Clear();
            txtInfo.Clear();
            dgDatos.ClearSelection();
        }

        private void btPromedio_Click(object sender, EventArgs e)
        {
            
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) {

                MessageBox.Show("solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar)) {e.Handled = false;}
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
