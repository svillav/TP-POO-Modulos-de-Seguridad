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
    public partial class Users : Form
    {
        //public Modelo.DTO.UsuariosDto userlogeado { get; set; }
        public int UserLogeadoID { get;private set; }
        protected Modelo.DTO.UsuariosDto UserLogeado;
        List<Modelo.DTO.UsuariosDto> listUsers;
        int rowindex=0;
        public Users()
        {

        }
        public Users(int id)
        {
            UserLogeadoID = id;
            InitializeComponent();
            deleteUser.Enabled = false;
            ModifyUser.Enabled = false;
            var listaperfiles = Controladora.ControladoraPerfiles.GetPerfiles();
            var listausuarios = Controladora.ControladoraUsuarios.GetUsuarios();
            UserLogeado = listausuarios.Find(x => x.Id == UserLogeadoID);
            LBCurrentUser.Text = LBCurrentUser.Text + UserLogeado.Email;
           // var userlogeado = listaperfiles.Find(x => x.Id == UserLogeadoID);
            if (UserLogeado.Perfil == listaperfiles.Where(x => x.ProfileN == "SuperAdmin").FirstOrDefault().Id ||
                UserLogeado.Perfil == listaperfiles.Where(x => x.ProfileN == "Admin").FirstOrDefault().Id ||
                UserLogeado.Perfil == listaperfiles.Where(x => x.ProfileN == "Chieff").FirstOrDefault().Id )
            {
                deleteUser.Enabled = true;
                ModifyUser.Enabled = true;
            }

            try
            {
                listUsers = Controladora.ControladoraUsuarios.GetUsuarios();
                dgvUsersList.DataSource = null;
                dgvUsersList.DataSource = listUsers;

            } catch (Exception e)
            {
                MessageBox.Show("Error al listar usuarios: " + e.Message);
            } 
        }

        private void dgvUsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsersList.CurrentRow.Selected = true;
            rowindex = int.Parse(e.RowIndex.ToString())+1 ;
            //MessageBox.Show(rowindex.ToString());
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            
            //if ()
            //{

            //}
            //GET SELECTED ROW
            /*Int32 selectedRowCount = dgvUsersList.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            MessageBox.Show("Selected Rows" + selectedRowCount);*/

            //Modelo.DTO.UsuariosDto selectedUser = dgvUsersList.SelectedRows[0].DataBoundItem as Modelo.DTO.UsuariosDto;
            
            
            if (rowindex>0)
            {
                
                try
                {
                    int inde = listUsers.IndexOf(listUsers.Single(i => i.Id == (Convert.ToInt32(dgvUsersList.Rows[rowindex].Cells[0].Value))));
                    var usuario = listUsers[inde - 1];
                    Controladora.ControladoraUsuarios.EliminarUsuario(usuario.Id.ToString());
                    listUsers = Controladora.ControladoraUsuarios.GetUsuarios();
                    dgvUsersList.DataSource = null;
                    dgvUsersList.DataSource = listUsers;

                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error al listar usuarios: " + exp);
                }
            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario");
            }


        }

        private void ModifyUser_Click(object sender, EventArgs e)
        {
            if (rowindex > 0)
            {

                try
                {
                    int inde = listUsers.IndexOf(listUsers.Single(i => i.Id == (Convert.ToInt32(dgvUsersList.Rows[rowindex].Cells[0].Value))));
                    var usuario = listUsers[inde-1];
                    EditUser edform = new EditUser(usuario.Id);
                    edform.ShowDialog();
                    dgvUsersList.DataSource = null;
                    dgvUsersList.DataSource = listUsers;

                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error al listar usuarios: " + exp);
                }
            }
            else
            {
                MessageBox.Show("Error al modificar el usuario");
            }
        }

        private void RefreshList_Click(object sender, EventArgs e)
        {
            try
            {
                listUsers = Controladora.ControladoraUsuarios.GetUsuarios();
                dgvUsersList.DataSource = null;
                dgvUsersList.DataSource = listUsers;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar usuarios: " + ex);
            }
        }

        private void Products(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }
    }
}
