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
                    Modelo.DTO.UsuariosDto usuario = new Modelo.DTO.UsuariosDto();
                    usuario.Name = txtName.Text;
                    usuario.Dni = int.Parse(txtDNI.Text);
                    usuario.Email = txtEmail.Text;
                    usuario.Contraseña = txtPassword.Text;
                    usuario.Perfil = 1;

                    //var listaPerfiles = Controladora.ControladoraPerfiles.GetPerfiles();
                   // Modelo.DTO.PerfilesDto cliente = listaPerfiles.Find(p => p.Id == 0);// cambiar a cliente
                    //Modelo.Perfiles perf = new Modelo.Perfiles();
                   // perf.Id = cliente.Id;
                   // perf.Nombre = cliente.Nombre;
                    //usuario.Perfil = new Modelo.Perfiles() { Id = 1, Nombre = "SuperAdmin", Usuario = null };//perf; //Convert.ToInt32(cliente.Id);

                    // MessageBox.Show(usuario.Perfil.Id.ToString()); //cartel que dice exactamente "3"

                    ControladoraUsuarios.AgregarUsuario(usuario);

                    MessageBox.Show("Usuario creado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cant Sign the user up because: " + ex.Message);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
