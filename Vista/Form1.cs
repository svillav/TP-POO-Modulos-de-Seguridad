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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•';
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void chckPW_CheckedChanged(object sender, EventArgs e)
        {
            if (chckPW.Checked == true)
            {
                txtPassword.PasswordChar = default;
            }
            else
            {
                txtPassword.PasswordChar = '•';
                
            }
        }

        private void picboxShowPW_Click(object sender, EventArgs e)
        {
            picboxShowPW.ImageLocation = "Img/ShowPW.png";
        }
    }
}
