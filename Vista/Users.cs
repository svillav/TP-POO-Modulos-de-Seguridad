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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();

            List<TestGetSet> strings2 = new List<TestGetSet>();

            strings2.Add(new TestGetSet("holas", 12));
            strings2.Add(new TestGetSet("holas", 12));
            strings2.Add(new TestGetSet("holas", 12));
            strings2.Add(new TestGetSet("holas", 12));
            strings2.Add(new TestGetSet("holas", 12));
            strings2.Add(new TestGetSet("holas", 12));
            strings2.Add(new TestGetSet("holas", 12));




            dgvUsersList.DataSource = strings2;
        }

        private void dgvUsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class TestGetSet
        {
            private string nombre2;
            private int edad2;

       public TestGetSet(string nombre, int edad)
        {
            this.nombre2 = nombre;
            this.edad2 = edad;
        }
            
            public string nombre
            {
                get { return nombre2; }
                set { nombre = nombre2; }
            }

            public int edad
            {
                get { return edad2; }
                set { edad = edad2; }
            }
        }
    }
