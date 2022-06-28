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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //txtRePassword
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //txtPassword

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //txtREmail
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //txtEmail

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //txtDNI


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //txtLastName
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //txtName
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtName.Text != string.Empty && txtEmail.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                try
                {
                    Usuario usuario = new Usuario();
                    usuario.Nombre = txtName.Text;
                    //usuario.LastName = txtLastName.Text;
                    usuario.Email = txtEmail.Text;
                    //person.User = txtUser.Text;
                    usuario.Contraseña = txtPassword.Text;
                    //person.ProfileID = 99;
                    //person.BirthDate = DateTime.Parse(txtDateOfBirth);

                    MessageBox.Show("Usuario creado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cant Sign the user up because:{0}",ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Complete los campos Nombre \n email \n contraseña \n tipo de usuario");
            }



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserType_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
