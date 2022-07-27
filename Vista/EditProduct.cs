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
    public partial class EditProduct : Form
    {
        public EditProduct(string Name)
        {
            InitializeComponent();

            var listProduct = Controladora.ControladoraProductos.GetProducts();

            var prod = listProduct.Find(x => x.ProductName == Name.ToString());
            txtName.Text = prod.ProductName;
            txtBrand.Text = prod.BrandName;
            txtDesc.Text = prod.DescriptionProduct;
            txtStock.Text = prod.StockProduct.ToString();

        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            var listProduct = Controladora.ControladoraProductos.GetProducts();
            Modelo.DTO.ProductosDto productModified = new Modelo.DTO.ProductosDto();

            try
            {
                productModified.ProductName = txtName.Text;
                productModified.BrandName = txtBrand.Text;
                productModified.DescriptionProduct = txtDesc.Text;
                productModified.StockProduct = int.Parse(txtStock.Text);

                Controladora.ControladoraProductos.EditProduct(productModified);
                MessageBox.Show("PRODUCTO MODIFICADO");
            
                txtName.Clear();
                txtBrand.Clear();
                txtDesc.Clear();
                txtStock.Clear();
                this.Close();
            }
            catch
            {
                MessageBox.Show("NO SE PUDO MODIFICAR EL PRODUCTO");
            }
        }
    }
}
