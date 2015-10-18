using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBob.DTO
{
    public class PricesDTO
    {
        public int Id { get; set; }
        public decimal PriceSizeSmall { get; set; }
        public decimal PriceSizeMedium { get; set; }
        public decimal PriceSizeLarge { get; set; }
        public decimal PriceCrustThin { get; set; }
        public decimal PriceCrustRegular { get; set; }
        public decimal PriceCrustThick { get; set; }
        public decimal Sausage { get; set; }
        public decimal Onions { get; set; }
        public decimal Pepperoni { get; set; }
        public decimal GreenPeppers { get; set; }
    }
}
