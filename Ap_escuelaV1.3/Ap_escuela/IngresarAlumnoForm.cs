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
    public partial class IngresarAlumnoForm : Form
    {
        public IngresarAlumnoForm()
        {
            InitializeComponent();
        }

        public Alumno AlumnoActual { get; set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Alumno Alumno = new Alumno();
                Alumno.Nombre = txtNombre.Text;
                Alumno.Apellido = txtApellido.Text;
                Alumno.Direccion = txtDireccion.Text;
                Alumno.Fecha_Nac = dtfecha.Value.ToShortDateString();


                int resultado = AlumnoDAL.Agregar(Alumno);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardados Correctamente !!", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                   
                }

                else
                {
                    MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
            txtDireccion.Clear();
            dtfecha.ResetText();
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

        private void dtfecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
