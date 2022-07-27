using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DTO
{
    public class ProductosDto
    {
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string DescriptionProduct { get; set; }
        public int StockProduct { get; set; }

        public ProductosDto() { }
    }

    public class Productos
    {
        public Productos() { }

        public static List<ProductosDto> GetProducts()
        {
            List<ProductosDto> ProductosDto;
            try
            {
                using (var ctx = new ModulosDeSeguridad())
                {
                    ProductosDto = new List<ProductosDto>();

                    var ListaProductos = ctx.Product;
                    if (ListaProductos != null)
                    {
                        foreach (var product in ListaProductos)
                        {
                            ProductosDto productstemp = new ProductosDto();
                            productstemp.ProductName = product.ProductName;
                            productstemp.BrandName = product.BrandName;
                            productstemp.DescriptionProduct = product.DescriptionProduct;
                            productstemp.StockProduct = product.StockProduct;
                            ProductosDto.Add(productstemp);
                        }
                    }
                }
                return ProductosDto;
            }
            catch
            {
                return new List<ProductosDto>();
            }
        }

        public static void EditProduct(ProductosDto prod)
        {
            try
            {
                using (var ctx = new ModulosDeSeguridad())
                {
                    var product = ctx.Product.Where(x => x.ProductName == prod.ProductName).FirstOrDefault();
                    ctx.Product.Remove(product);

                    Product productoEditado = new Product();
                    productoEditado.ProductName = prod.ProductName;
                    productoEditado.BrandName = prod.BrandName;
                    productoEditado.DescriptionProduct = prod.DescriptionProduct;
                    productoEditado.StockProduct = prod.StockProduct;
                    ctx.Product.Add(productoEditado);
                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public static void DeleteProduct(string Name)
        {
            try
            {
                using (var ctx = new ModulosDeSeguridad())
                {
                    var product = ctx.Product.Where(x => x.ProductName == Name).FirstOrDefault();
                    ctx.Product.Remove(product);
                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public static void AddProduct(Modelo.DTO.ProductosDto product)
        {
            try
            {
                using (var ctx = new ModulosDeSeguridad())
                {
                    Product newProduct = new Product();
                    newProduct.ProductName = product.ProductName;
                    newProduct.BrandName = product.BrandName;
                    newProduct.DescriptionProduct = product.DescriptionProduct;
                    newProduct.StockProduct = product.StockProduct;
                    ctx.Product.Add(newProduct);
                    ctx.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
