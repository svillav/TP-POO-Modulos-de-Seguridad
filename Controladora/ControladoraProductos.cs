using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProductos
    {
        public static List<Modelo.DTO.ProductosDto> GetProducts()
        {
            return Modelo.DTO.Productos.GetProducts();
        }
        public static void AddProduct(Modelo.DTO.ProductosDto product)
        {
            Modelo.DTO.Productos.AddProduct(product);
        }
        public static void DeleteProduct(string Name)
        {
            Modelo.DTO.Productos.DeleteProduct(Name);
        }
        public static void EditProduct(Modelo.DTO.ProductosDto producto)
        {
            Modelo.DTO.Productos.EditProduct(producto);
        }
    }
}
