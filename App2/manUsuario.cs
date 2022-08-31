using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dni = txtEmail.Text;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String telefono = txtTelefono.Text;
            String email = txtEmail.Text;
            String fecNac = dateBirth.Text;
            String direccion = txtDireccion.Text;

            tablaUsuarios.Rows.Add(dni, nombre, apellido, telefono, email, fecNac, direccion);
        }
    }
}
