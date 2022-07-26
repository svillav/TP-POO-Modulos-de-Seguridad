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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();

            dgvProducts.ColumnCount = 4;

            dgvProducts.Columns[0].Name = "Producto";
            dgvProducts.Columns[1].Name = "Marca";
            dgvProducts.Columns[2].Name = "Descripcion";
            dgvProducts.Columns[3].Name = "Stock";

            string[] row = new string[] { "Papas", "McCain", "Versión para horno", "6"};
            dgvProducts.Rows.Add(row);
            row = new string[] { "Mayonesa", "Natura", "Light", "9" };
            dgvProducts.Rows.Add(row);
            row = new string[] { "Ketchup", "Danica", "Picante", "10" };
            dgvProducts.Rows.Add(row);
            row = new string[] { "Jamon", "Paladini", "Serrano", "20" };
            dgvProducts.Rows.Add(row);

            //agregar botones de + y - entre la columna de stock
            putColumnsAddAndSubstract();
            
        }

        private void putColumnsAddAndSubstract()
        {
            DataGridViewButtonColumn addToStock = new DataGridViewButtonColumn();
            addToStock.HeaderText = "Add";
            addToStock.Text = "+";
            addToStock.Name = "btnAdd";
            addToStock.UseColumnTextForButtonValue = true;
            dgvProducts.Columns.Insert(3, addToStock);

            DataGridViewButtonColumn substractToStock = new DataGridViewButtonColumn();
            substractToStock.HeaderText = "Substract";
            substractToStock.Text = "-";
            substractToStock.Name = "btnSubstract";
            substractToStock.UseColumnTextForButtonValue = true;
            dgvProducts.Columns.Insert(5, substractToStock);

            dgvProducts.Columns[3].DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, FontStyle.Bold);
            dgvProducts.Columns[5].DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, FontStyle.Bold);
        }
    }
}
