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
    public partial class EliminarAlumnoForm : Form
    {
        public EliminarAlumnoForm()
        {
            InitializeComponent();
        }

        public Alumno AlumnoActual { get; set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Alumno> Lista = AlumnoDAL.BuscarAlumnos(txtNombre.Text, txtApellido.Text, true);

            if (Lista.Count <= 0)
            {
                MessageBox.Show("Alumno No Encontrado, Imposible Eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var al = Lista.First();

            int resultado = AlumnoDAL.Eliminar(al.Id);

            if (resultado > 0)
            {
                MessageBox.Show("Alumno Eliminado Correctamente !!", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar lo datos", "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CrearUsuario re = new CrearUsuario();
            re.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

       
       
    }
}
