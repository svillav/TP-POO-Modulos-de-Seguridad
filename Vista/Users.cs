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
                List<Modelo.Usuario> listUsers = Controladora.ControladoraUsuarios.obtener_instancia().Listar_Usuarios();
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

        }

        private void ModifyUser_Click(object sender, EventArgs e)
        {

        }

        private void RefreshList_Click(object sender, EventArgs e)
        {

        }
        
    }
}
