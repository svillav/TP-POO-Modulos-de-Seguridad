using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Function : Form
    {
        int IDUserLog = 0;
        public Function(int IdUSerLog)
        {
            IDUserLog = IdUSerLog;
            InitializeComponent();
            var listausuarios = Controladora.ControladoraUsuarios.GetUsuarios();
            Modelo.DTO.UsuariosDto UserLogeado = listausuarios.Find(x => x.Id == IdUSerLog);
            UserLbl.Text = UserLbl.Text + UserLogeado.Email.ToString();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            Users users = new Users(IDUserLog);
            users.Show();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            Products products = new Products(IDUserLog);
            products.Show();
        }
    }
}
