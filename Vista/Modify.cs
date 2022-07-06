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
    public partial class Modify : Form
    {
        public Modify(int ID)
        {
            InitializeComponent();

            Modelo.Usuario userToModify = Controladora.ControladoraUsuarios.get_instance().Obtener_Usuario(ID);
            
            Name.Text = userToModify.Name;
            Email.Text = userToModify.Email;
            DNI.Text = userToModify.Dni;
            
        }
    }
}
