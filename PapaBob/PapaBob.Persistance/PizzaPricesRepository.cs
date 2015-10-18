using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBob.Persistance
{
    public class PizzaPricesRepository
    {
        public static DTO.PricesDTO getPrices()
        {
            PapaBobDbEntities db = new PapaBobDbEntities();

            var prices = db.PizzaPrices.First();
            var dtoPrices = converDTOPrices(prices);
            return dtoPrices;
        }

        private static DTO.PricesDTO converDTOPrices(PizzaPrice prices)
        {
            DTO.PricesDTO dtoPrices = new DTO.PricesDTO();
            dtoPrices.Id = prices.Id;
            dtoPrices.Onions = prices.Onions;
            dtoPrices.Pepperoni = prices.Pepperoni;
            dtoPrices.Sausage = prices.Sausage;
            dtoPrices.GreenPeppers = prices.GreenPeppers;
            dtoPrices.PriceCrustRegular = prices.PriceCrustRegular;
            dtoPrices.PriceCrustThick = prices.PriceCrustThick;
            dtoPrices.PriceCrustThin = prices.PriceCrustThin;
            dtoPrices.PriceSizeLarge = prices.PriceSizeLarge;
            dtoPrices.PriceSizeMedium = prices.PriceSizeMedium;
            dtoPrices.PriceSizeSmall = prices.PriceSizeSmall;

            return dtoPrices;
        }
    }
}
