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
        public Users()
        {
            InitializeComponent();

            try
            {
                dgvUsersList.DataSource = listUsers();

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
            Modelo.Usuario selectedUser = dgvUsersList.SelectedRows[0].DataBoundItem as Modelo.Usuario;
            Controladora.ControladoraUsuarios.get_instance().Delete_User(selectedUser);
            dgvUsersList.DataSource = listUsers();
        }

        private void ModifyUser_Click(object sender, EventArgs e)
        {
            int selectedUser = dgvUsersList.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            if (dgvUsersList.SelectedRows.Count == 1)
            {
                Modify modify = new Modify(selectedUser + 1);
                modify.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un unico usuario para modificar");
            }
        }

        private void RefreshList_Click(object sender, EventArgs e)
        {
            dgvUsersList.DataSource = listUsers();
        }

        private List<Modelo.Usuario> listUsers()
        {
            return Controladora.ControladoraUsuarios.get_instance().list_users();
        }
        
    }
}
