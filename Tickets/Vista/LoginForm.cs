using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {

            if (UsuariotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsuariotextBox, "Ingrese un usuario");
                UsuariotextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ContrasenatextBox.Text))
            {
                errorProvider1.SetError(ContrasenatextBox, "Ingrese una contraseña");
                ContrasenatextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            // validar base de datos
            Login login = new Login(UsuariotextBox.Text, ContrasenatextBox.Text);
            UsuarioDB usuarioDB = new UsuarioDB();

            usuarioDB = new UsuarioDB(login);
            if (usuarioDB != null)
            {
                //Montramos el Menu
                Menu menuFormulario = new Menu();
                Hide();
                menuFormulario.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
