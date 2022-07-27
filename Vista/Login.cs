using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using Modelo;


namespace Vista
{
    
    public partial class Login : Form
    {

        public Modelo.DTO.UsuariosDto userlogeado;
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•';
            lblUser.Visible = true;
            lblPassword.Visible = true;
            txtUser.Visible = true;
            txtPassword.Visible = true;
            btnSignIn.Visible = true;
            btnSignIn.Visible = true;
            SingUp.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void chckPW_CheckedChanged(object sender, EventArgs e)
        {
            if (chckPW.Checked == true)
            {
                txtPassword.PasswordChar = default;
            }
            else
            {
                txtPassword.PasswordChar = '•';
                
            }
        }

        private void picboxShowPW_Click(object sender, EventArgs e)
        {
            //picboxShowPW.ImageLocation = "Img/ShowPW.png";
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Users users = new Users();
            //users.ShowDialog();
            bool login = Controladora.ValidInfoUserCtrl.ValidateUserPassword(txtUser.Text, Encrypt.EncodePassword(txtPassword.Text));
            if (login)
            {
                var userlog = new Modelo.DTO.UsuariosDto();
                var lapeorvariabledelmundo = Controladora.ControladoraUsuarios.GetUsuarios();
                userlog = lapeorvariabledelmundo.Find(x => x.Email.ToString() == txtUser.Text.ToString());

                Function function = new Function(userlog.Id);
                function.Show();
            }
            else
            {
                MessageBox.Show("No se encontro el usuario o la contraseña");
            }

            /*
            //var ListarUsuarios = ControladoraUsuarios.obtener_instancia().Listar_Usuarios();
            var listausuarios = Controladora.ControladoraUsuarios.GetUsuarios();
            Modelo.DTO.UsuariosDto usuario = listausuarios.Find(u => (u.Name == txtUser.Text || u.Email == txtUser.Text) && u.Contraseña == txtPassword.Text);

            if(usuario != null)
            {
                Users users = new Users();
                users.Show();
            }
            else 
            { 
                MessageBox.Show("Credenciales invalidas"); 
            }   */

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

        }
    }
}
