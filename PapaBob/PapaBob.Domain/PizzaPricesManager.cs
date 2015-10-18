using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBob.Domain
{
    class PizzaPricesManager
    {
        public static decimal CheckTotal(DTO.OrderDTO order)
        {
            decimal totalCost = 0;
            var prices = Persistance.PizzaPricesRepository.getPrices();
            
            totalCost += getSizePrice(order,prices);
            totalCost += getCrustPrice(order,prices);
            totalCost += getToppingsPrice(order, prices);
            return totalCost;
        }

        private static decimal getToppingsPrice(DTO.OrderDTO order, DTO.PricesDTO prices)
        {
            decimal price = 0;
            
            if (order.Sausage == true) price += prices.Sausage;
            if (order.Pepperoni == true) price += prices.Pepperoni;
            if (order.Onions == true) price += prices.Onions;
            if (order.GreenPeppers == true) price += prices.GreenPeppers;
            return price;
        }

        private static decimal getCrustPrice(DTO.OrderDTO order, DTO.PricesDTO prices)
        {
            decimal price = 0;
            if (order.Crust == DTO.Enums.CrustType.Regular) price = prices.PriceCrustRegular;
            if (order.Crust == DTO.Enums.CrustType.Thin) price = prices.PriceCrustThin;
            if (order.Crust == DTO.Enums.CrustType.Thick) price = prices.PriceCrustThick;
            return price;
        }


        private static decimal getSizePrice(DTO.OrderDTO order, DTO.PricesDTO prices)
        {
            decimal price = 0;
            if (order.Size == DTO.Enums.SizeType.Small) price = prices.PriceSizeSmall;
            if (order.Size == DTO.Enums.SizeType.Medium) price = prices.PriceSizeMedium;
            if (order.Size == DTO.Enums.SizeType.Large) price = prices.PriceSizeLarge;
            return price;
        }
    }
}
