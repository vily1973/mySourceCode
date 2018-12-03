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
    public partial class Autentificacion : Form
    {
        public Autentificacion()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(UsuarioDAL.Autentificar(txtUsuario.Text,txtContraseña.Text)>0)
            {
                this.Hide();
                MenuForm f=new MenuForm();
                f.ShowDialog();
                this.Close();
            }
            else
                    MessageBox.Show("Error en los datos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (UsuarioDAL.Autentificar(txtUsuario.Text, txtContraseña.Text) > 0)
                {
                    this.Hide();
                    CrearCuentaForm f = new CrearCuentaForm();
                    f.ShowDialog();
                }
                else
                    MessageBox.Show("Error en los datos");

            }
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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
