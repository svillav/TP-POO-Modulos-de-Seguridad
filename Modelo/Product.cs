namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Product")]
    public partial class Product
    {
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        public string BrandName { get; set; }

        [Required]
        [StringLength(100)]
        public string DescriptionProduct { get; set; }

        [Required]
        public int StockProduct { get; set; }
    }
}
