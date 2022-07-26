namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string BrandName { get; set; }

        [StringLength(100)]
        public string DescriptionProduct { get; set; }

        public int StockProduct { get; set; }
    }
}
