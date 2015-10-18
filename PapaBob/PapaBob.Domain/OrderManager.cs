using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBob.Domain
{
    public class OrderManager
    {
        public static void AddOrder(DTO.OrderDTO order)
        {
            Persistance.OrderRepository.AddOrder(order);

        }
        public static decimal ChecktTotal(DTO.OrderDTO order)
        {
          
            order.TotalCost=PizzaPricesManager.CheckTotal(order);
            return order.TotalCost;
        }

        public static List<DTO.OrderDTO> GetOders()
        {
            var orders = Persistance.OrderRepository.GetOrders();
            return orders;
        }

        public static void CompleteOrder(Guid orderId)
        {
            Persistance.OrderRepository.CompleteOrder(orderId);
        }
    }
}
