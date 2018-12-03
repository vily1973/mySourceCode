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
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (UsuarioDAL.BuscarUsuario(txtUsuario.Text) == true)
            {
                MessageBox.Show("Usuario ya registrado");
                return;
            }

            if (txtContraseña.TextLength <= 0)
            {
                MessageBox.Show("Debe ingresar una contraseña valida");
                txtContraseña.Clear();
                txtConfirmar.Clear();
            }
            else if (txtContraseña.Text != txtConfirmar.Text)
            {
                MessageBox.Show("Contraseñas no coinciden");
                txtContraseña.Clear();
                txtConfirmar.Clear();
            }
            else if (txtContraseña.Text == txtContraseña.Text)
            {
                if (UsuarioDAL.CrearCuentas(txtUsuario.Text, txtContraseña.Text) > 0)
                {
                    MessageBox.Show("Cuenta Creada con exito");
                }
                else
                    MessageBox.Show("No se pudo crear la cuenta");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

        

        
   