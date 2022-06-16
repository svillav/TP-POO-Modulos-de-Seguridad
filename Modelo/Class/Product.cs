using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Class
{
    public class Product
    {
        public int ProductId { get; set; }                       //internal codebar
        public string ProductName { get; set; }
        public char Factor { get; set; }                         //W for Weight and U for Unity. eg: Bread is sold by weight and candys by unity
        public string CodeBar { get; set; }                      //public codebar
        public string Category { get; set; }                     //
        public string Replenisher { get; set; }                  //wich branch is bringin the product
        public decimal Cost { get; set; }
        public decimal CostNow { get; set; }                     //Argeninian inflation make the costs change every moment, we can buy a product on april and the cost now in june is different, so the calc we have to do for the gaining is different
        public decimal Price { get; set; }
        public decimal PriceNow { get; set; }                    // Same of CostNow
        public string GainingPercentage { get; private set; }    // by a matematician method we set the gaining. taking the CostNow and the PriceNow


    }
}
