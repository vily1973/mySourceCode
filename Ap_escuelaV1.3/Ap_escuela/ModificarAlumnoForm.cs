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
    public partial class ModificarAlumnoForm : Form
    {
        public ModificarAlumnoForm()
        {
            InitializeComponent();
        }

        public Alumno AlumnoActual { get; set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*
            if (UsuarioDAL.BuscarUsuario(txtNombre) == true)
            {
                MessageBox.Show("Usuario ya registrado");
                return;
            }
            */

            List<Alumno> Lista = AlumnoDAL.BuscarAlumnos(txtNombre.Text, txtApellido.Text, true);

            if (Lista.Count <= 0)
            {
                MessageBox.Show("Alumno No Encontrado, Imposible Modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var al = Lista.First();

            al.Nombre = txtNombre.Text;
            al.Apellido = txtApellido.Text;
            al.Direccion = txtDireccion.Text;
            al.Fecha_Nac = dtfecha.Value.ToShortDateString();

            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = AlumnoDAL.Eliminar(al.Id);

                if (resultado > 0)
                {
                    Alumno Alumno = new Alumno();
                    Alumno.Nombre = txtNombre.Text;
                    Alumno.Apellido = txtApellido.Text;
                    Alumno.Direccion = txtDireccion.Text;
                    Alumno.Fecha_Nac = dtfecha.Value.ToShortDateString();


                    resultado = AlumnoDAL.Agregar(Alumno);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Datos Modificados Correctamente !!", "Datos Modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();

                    }

                    else
                    {
                        MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                else
                {
                    MessageBox.Show("No se pudo Modificar el alumno", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

       
       
    }
}
