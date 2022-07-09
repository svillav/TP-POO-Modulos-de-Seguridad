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
    public partial class Users : Form
    {
        List<Modelo.DTO.UsuariosDto> listUsers;
        public Users()
        {
            InitializeComponent();

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

        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            //GET SELECTED ROW
            /*Int32 selectedRowCount = dgvUsersList.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            MessageBox.Show("Selected Rows" + selectedRowCount);*/

            //Modelo.Usuario selectedUser = dgvUsersList.SelectedRows[0].DataBoundItem as Modelo.Usuario;
            //Controladora.ControladoraUsuarios.obtener_instancia().Eliminar_Usuario(selectedUser);
            //dgvUserList.DataSource = null;
            dgvUsersList.DataSource = listUsers;

        }

        private void ModifyUser_Click(object sender, EventArgs e)
        {

        }

        private void RefreshList_Click(object sender, EventArgs e)
        {
            dgvUsersList.DataSource = null;
            dgvUsersList.DataSource = listUsers;
        }

        
        
    }
}
