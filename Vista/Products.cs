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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();

            try
            {
               List<Modelo.DTO.ProductosDto> listProducts = Controladora.ControladoraProductos.GetProducts();
               dgvProducts.DataSource = null;
               dgvProducts.DataSource = listProducts;
                //agregar botones de + y - entre la columna de stock
                putColumnsAddAndSubstract();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al listar usuarios: " + e.Message);
            }          
            
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

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());

            if (e.ColumnIndex == 0)
            {
                //AGREGAR UNIDAD
                var listProducts = Controladora.ControladoraProductos.GetProducts();
                Modelo.DTO.ProductosDto productModified = new Modelo.DTO.ProductosDto();

                try
                {
                    var currentProduct = listProducts.Find(x => x.ProductName.ToString() == this.dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString());
                    

                    productModified.ProductName = currentProduct.ProductName;
                    productModified.BrandName = currentProduct.BrandName;
                    productModified.DescriptionProduct = currentProduct.DescriptionProduct;
                    productModified.StockProduct = currentProduct.StockProduct + 1;

                    this.dgvProducts.Rows[e.RowIndex].Cells[5].Value = productModified.StockProduct;
                    Controladora.ControladoraProductos.EditarProducto(productModified);

                }
                catch
                {
                    MessageBox.Show("NO SE PUDO MODIFICAR EL PRODUCTO");
                }

            }
            else if(e.ColumnIndex == 1)
            {
                //RESTAR UNIDAD
                var listProducts = Controladora.ControladoraProductos.GetProducts();
                Modelo.DTO.ProductosDto productModified = new Modelo.DTO.ProductosDto();

                try
                {
                    var currentProduct = listProducts.Find(x => x.ProductName.ToString() == this.dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString());


                    productModified.ProductName = currentProduct.ProductName;
                    productModified.BrandName = currentProduct.BrandName;
                    productModified.DescriptionProduct = currentProduct.DescriptionProduct;
                    productModified.StockProduct = currentProduct.StockProduct - 1;

                    this.dgvProducts.Rows[e.RowIndex].Cells[5].Value = productModified.StockProduct;
                    Controladora.ControladoraProductos.EditarProducto(productModified);

                }
                catch
                {
                    MessageBox.Show("NO SE PUDO MODIFICAR EL PRODUCTO");
                }
            }
        }
    }
}
