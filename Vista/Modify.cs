using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controladora;

namespace Vista
{
    public partial class Modify : Form
    {

        Modelo.Usuario currentUser = new Usuario();

        public Modify(int ID)
        {
            InitializeComponent();

            currentUser = Controladora.ControladoraUsuarios.get_instance().Get_User(ID);
            if (currentUser != null)
            {
                MessageBox.Show(currentUser.Name.ToString());
                NameTB.Text = currentUser.Name;
                EmailTB.Text = currentUser.Email;
                DNITB.Text = currentUser.Dni;
            }
            else { MessageBox.Show("No existe el usuario"); }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Modelo.Usuario userModify = new Usuario();
            try
            {
                if (currentUser != null)
                {
                    userModify.Id = currentUser.Id;
                    userModify.Name = NameTB.Text;
                    userModify.Email = EmailTB.Text;
                    userModify.Dni = DNITB.Text;
                    userModify.Perfil = currentUser.Perfil;
                }

                if (PasswordTB.Text == RepeatPassTB.Text)
                {
                    userModify.Password = PasswordTB.Text;
                }

                Controladora.ControladoraUsuarios.get_instance().Modify_User(currentUser, userModify);
                Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
