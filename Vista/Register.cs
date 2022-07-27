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
using Modelo.Enum;

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
                bool namevalid = false; bool emailvalid = false; bool dnivalid = false;bool pwvalid = false; //validadores de string
                bool emaildb = false, dnidb = false; //validadores de ddbb

                try//valido los strings 
                {

                    //namevalid = Controladora.ValidInfoUserCtrl.Validate(Enums.ValidType.CheckValid, Enums.PropertieType.Name, txtName.Text);
                    //emailvalid = Controladora.ValidInfoUserCtrl.Validate(Enums.ValidType.CheckValid, Enums.PropertieType.Email, txtEmail.Text);
                    //dnivalid = Controladora.ValidInfoUserCtrl.Validate(Enums.ValidType.CheckValid, Enums.PropertieType.DNI, txtDNI.Text);
                    //pwvalid = Controladora.ValidInfoUserCtrl.Validate(Enums.ValidType.CheckValid, Enums.PropertieType.Password, txtPassword.Text);
                    ////los verificadores de base de datos van en el mismo try porque antes con menos seguridad se creaban cuentas y puede
                    ////que haya cuentas que tengan menos seguridad pero no hayan cambiado
                    //emaildb = Controladora.ValidInfoUserCtrl.Validate(Enums.ValidType.CheckDDBB, Enums.PropertieType.Email, txtEmail.Text);
                    //dnidb = Controladora.ValidInfoUserCtrl.Validate(Enums.ValidType.CheckDDBB, Enums.PropertieType.DNI, txtDNI.Text);


                    namevalid = Controladora.ValidInfoUserCtrl.Validate(Convert.ToInt32(Enums.ValidType.CheckValid), Convert.ToInt32(Enums.PropertieType.Name), txtName.Text);
                    emailvalid = Controladora.ValidInfoUserCtrl.Validate(Convert.ToInt32(Enums.ValidType.CheckValid), Convert.ToInt32(Enums.PropertieType.Email), txtEmail.Text);
                    dnivalid = Controladora.ValidInfoUserCtrl.Validate(Convert.ToInt32(Enums.ValidType.CheckValid), Convert.ToInt32(Enums.PropertieType.DNI), txtDNI.Text);
                    pwvalid = Controladora.ValidInfoUserCtrl.Validate(Convert.ToInt32(Enums.ValidType.CheckValid), Convert.ToInt32(Enums.PropertieType.Password), txtPassword.Text);
                    //los verificadores de base de datos van en el mismo try porque antes con menos seguridad se creaban cuentas y puede
                    //que haya cuentas que tengan menos seguridad pero no hayan cambiado
                    emaildb = Controladora.ValidInfoUserCtrl.Validate(Convert.ToInt32(Enums.ValidType.CheckDDBB), Convert.ToInt32(Enums.PropertieType.Email), txtEmail.Text);
                    dnidb = Controladora.ValidInfoUserCtrl.Validate(Convert.ToInt32(Enums.ValidType.CheckDDBB), Convert.ToInt32(Enums.PropertieType.DNI), txtDNI.Text);
                    //
                    ///
                    ///codigo feo
                    ///
                    //
                    string cartel ="";
                    if (!namevalid) { cartel += "Nombre Invalido"; }
                    if (!emailvalid) { cartel += "\nEmail Invalido"; }
                    if (!dnivalid) { cartel += "\nDNI Invalido"; }
                    if (!pwvalid) { cartel += "\nContraseña Invalida"; }
                    if (emaildb== true) { cartel += "\nEl usuario ya existe en la base de datos"; }
                    if (dnidb== true) { cartel += "\nEl DNI ya existe en la base de datos"; }

                    //
                    ///
                    ///codigo feo
                    ///
                    //
                    if (cartel.Length > 1) { MessageBox.Show(cartel); }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }



                if (namevalid == true &&
                    emailvalid == true && 
                    dnivalid == true && 
                    pwvalid == true && 
                    emaildb == false && 
                    dnidb ==false)
                {

                
                    try
                    {
                        Modelo.DTO.UsuariosDto usuario = new Modelo.DTO.UsuariosDto();
                        usuario.Name = txtName.Text;
                        usuario.Dni = int.Parse(txtDNI.Text);
                        usuario.Email = txtEmail.Text;
                        usuario.Contraseña = Encrypt.EncodePassword(txtPassword.Text);
                        usuario.Perfil = 1;

                        ControladoraUsuarios.AgregarUsuario(usuario);

                        MessageBox.Show("Usuario creado");

                        txtName.Clear();
                        txtEmail.Clear();
                        txtDNI.Clear();
                        txtPassword.Clear();
                        txtRePassword.Clear();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo ingresar el usuario porque:" + ex.Message);
                    }
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
