using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ap_escuela
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            CrearCuentaForm f = new CrearCuentaForm();
            f.ShowDialog();
            */
            CrearUsuario re = new CrearUsuario();
            re.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Autentificacion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing only any letter OR Digit and Allowing BackSpace character
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarAlumnoForm re = new IngresarAlumnoForm();
            re.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarAlumnoForm re = new BuscarAlumnoForm();
            re.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible Proximamente...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarAlumnoForm re = new ModificarAlumnoForm();
            re.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EliminarAlumnoForm re = new EliminarAlumnoForm();
            re.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible Proximamente...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible Proximamente...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
