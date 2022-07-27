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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                Modelo.DTO.ProductosDto product = new Modelo.DTO.ProductosDto();
                product.ProductName = txtName.Text;
                product.BrandName = txtBrand.Text;
                product.DescriptionProduct = txtDesc.Text;
                product.StockProduct = int.Parse(txtStock.Text);

                ControladoraProductos.AddProduct(product);

                MessageBox.Show("Producto agregado");

                txtName.Clear();
                txtBrand.Clear();
                txtDesc.Clear();
                txtStock.Clear();
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el producto:" + ex.Message);
            }
        }
    }
}
