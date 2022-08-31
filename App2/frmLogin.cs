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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            bool Lok = false;
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(new Usuario { nombre = "admin", clave = "admin123"});
            usuarios.Add(new Usuario { nombre = "atsumi", clave = "tecsup" });
            String Lnombre = txtUsuario.Text;
            String Lclave = txtPassword.Text;
            for(int i = 0; i < usuarios.Count; i++)
            {
                if(Lnombre == usuarios[i].nombre && Lclave == usuarios[i].clave)
                {
                    Lok = true;
                }
            }
            if (Lok)
            {
                MainMDI principal = new MainMDI();
                principal.Show();
                this.Hide();
            } else
            {
                LoginError error = new LoginError();
                error.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
