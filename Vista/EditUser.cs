using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Enum;

namespace Vista
{
    
    public partial class EditUser : Form
    {
        public int ide { get; private set; }
        public EditUser()
        {

        }
        public EditUser(int idd)
        {
            ide = idd;
            InitializeComponent();
           // ddlPerfiles.Items.Add("asd");
            //ddlPerfiles.Items.Add("asd2");
            //listProfile.Items.Add();
            var lista = Controladora.ControladoraPerfiles.GetPerfiles();
            foreach (var perfil in lista)
            {
                listProfile.Items.Add(perfil.ProfileN.ToString());
               // ddlPerfiles.Items.Add(perfil.ProfileN.ToString());
            }
            if (ide != null && ide >0)
            {
                var listUsers = Controladora.ControladoraUsuarios.GetUsuarios();
                var usu = listUsers.Find(x => x.Id.ToString() == ide.ToString());
                txtName.Text = usu.Name;
                txtEmail.Text = usu.Email;
                txtDNI.Text = usu.Dni.ToString();
                txtPassword.Text = usu.Contraseña;
                txtRePassword.Text = usu.Contraseña;



            }
            else
            {
                MessageBox.Show("Usuario cargado incorrectamente");
                btnSubmit.Enabled = false;
            }
            


        }

        private void ddlPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var lista = Controladora.ControladoraPerfiles.GetPerfiles();
            Modelo.DTO.UsuariosDto usermodificado = new Modelo.DTO.UsuariosDto();
            bool namevalid = false; bool emailvalid = false; bool dnivalid = false; bool pwvalid = false; //validadores de string
            bool emaildb = false, dnidb = false; //validadores de ddbb

            try
            {
                if (txtPassword.Text == txtRePassword.Text)
                {

                    namevalid = Controladora.ValidInfoUserCtrl.Validate(Convert.ToInt32(Enums.ValidType.CheckValid), Convert.ToInt32(Enums.PropertieType.Name), txtName.Text);
                    emailvalid = Controladora.ValidInfoUserCtrl.Validate(Convert.ToInt32(Enums.ValidType.CheckValid), Convert.ToInt32(Enums.PropertieType.Email), txtEmail.Text);
                    dnivalid = Controladora.ValidInfoUserCtrl.Validate(Convert.ToInt32(Enums.ValidType.CheckValid), Convert.ToInt32(Enums.PropertieType.DNI), txtDNI.Text);
                    pwvalid = Controladora.ValidInfoUserCtrl.Validate(Convert.ToInt32(Enums.ValidType.CheckValid), Convert.ToInt32(Enums.PropertieType.Password), txtPassword.Text);
                    //los verificadores de base de datos van en el mismo try porque antes con menos seguridad se creaban cuentas y puede
                    //que haya cuentas que tengan menos seguridad pero no hayan cambiado
                    emaildb = Controladora.ValidInfoUserCtrl.Validate(Convert.ToInt32(Enums.ValidType.CheckDDBB), Convert.ToInt32(Enums.PropertieType.Email), txtEmail.Text);
                    dnidb = Controladora.ValidInfoUserCtrl.Validate(Convert.ToInt32(Enums.ValidType.CheckDDBB), Convert.ToInt32(Enums.PropertieType.DNI), txtDNI.Text);


                    string cartel = "";
                    if (!namevalid) { cartel += "Nombre Invalido"; }
                    if (!emailvalid) { cartel += "\nEmail Invalido"; }
                    if (!dnivalid) { cartel += "\nDNI Invalido"; }
                    if (!pwvalid) { cartel += "\nContraseña Invalida"; }
                    if (emaildb == true) { cartel += "\nEl usuario ya existe en la base de datos"; }
                    if (dnidb == true) { cartel += "\nEl DNI ya existe en la base de datos"; }
                    if (cartel.Length>1) { MessageBox.Show(cartel); }

                    if (namevalid == true &&
                    emailvalid == true &&
                    dnivalid == true &&
                    pwvalid == true &&
                    emaildb == false &&
                    dnidb == false)
                    {
                        usermodificado.Id = ide;
                        usermodificado.Name = txtName.Text;
                        usermodificado.Email = txtEmail.Text;
                        usermodificado.Dni = int.Parse(txtDNI.Text);
                        usermodificado.Contraseña = txtPassword.Text;
                        usermodificado.Perfil = Convert.ToInt32(lista.Find(x => x.ProfileN.ToString() == listProfile.Text.ToString()).Id);
                        Controladora.ControladoraUsuarios.EditarUsuario(usermodificado);
                        MessageBox.Show("USUARIO MODIFICADO");
                    }

                    




                    txtName.Clear();
                    txtEmail.Clear();
                    txtDNI.Clear();
                    txtPassword.Clear();
                    txtRePassword.Clear();
                    ide = -1;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN");
                }
                
            }
            catch
            {
                MessageBox.Show("NO SE PUDO MODIFICAR EL USUARIO");
            }
        }
    }
}
