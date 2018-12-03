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
    public partial class BuscarAlumnoForm : Form
    {
        public BuscarAlumnoForm()
        {
            InitializeComponent();
        }

        public Alumno AlumnoSeleccionado { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AlumnoDAL.BuscarAlumnos(txtNombre.Text, txtApellido.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
