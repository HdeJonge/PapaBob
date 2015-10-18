using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBob.Persistance
{
    public class OrderRepository
    {
        public static void AddOrder(DTO.OrderDTO newOrder)
        {

            PapaBobDbEntities db = new PapaBobDbEntities();

            var dbOrders = db.Orders;

            var dtoOrder = convertToOrder(newOrder);
            
            dbOrders.Add(dtoOrder);
            db.SaveChanges();
        }

        private static Order convertToOrder(DTO.OrderDTO newOrder)
        {
            var dtoOrder = new Order();

            dtoOrder.OrderId = Guid.NewGuid();
            dtoOrder.Completed = newOrder.Completed;
            dtoOrder.Size = newOrder.Size;
            dtoOrder.Crust = newOrder.Crust;
            dtoOrder.Sausage = newOrder.Sausage;
            dtoOrder.Pepperoni = newOrder.Pepperoni;
            dtoOrder.GreenPeppers = newOrder.GreenPeppers;
            dtoOrder.Onions = newOrder.Onions;
            dtoOrder.Name = newOrder.Name;
            dtoOrder.Address = newOrder.Address;
            dtoOrder.Zip = newOrder.Zip;
            dtoOrder.Phone = newOrder.Phone;
            dtoOrder.Payment = newOrder.Payment;
            dtoOrder.TotalCost = newOrder.TotalCost;

            return dtoOrder;
        }

        public static List<DTO.OrderDTO> GetOrders()
        {
            PapaBobDbEntities db = new PapaBobDbEntities();
            var dbOrders = db.Orders.Where(p => p.Completed == false);

            var dtoOrders = new List<DTO.OrderDTO>();

            foreach (var dbOrder in dbOrders)
            {
                var dtoOrder = new DTO.OrderDTO();

                dtoOrder.OrderId = dbOrder.OrderId;
                dtoOrder.Size = dbOrder.Size;
                dtoOrder.Crust = dbOrder.Crust;
                dtoOrder.Sausage = dbOrder.Sausage;
                dtoOrder.Onions = dbOrder.Onions;
                dtoOrder.Pepperoni = dbOrder.Pepperoni;
                dtoOrder.GreenPeppers = dbOrder.GreenPeppers;
                dtoOrder.Name = dbOrder.Name;
                dtoOrder.Address = dbOrder.Address;
                dtoOrder.Zip = dbOrder.Zip;
                dtoOrder.Phone = dbOrder.Phone;
                dtoOrder.Payment = dbOrder.Payment;
                dtoOrder.Completed = dbOrder.Completed;
                dtoOrder.TotalCost = dbOrder.TotalCost;

                dtoOrders.Add(dtoOrder);
            }

            return dtoOrders;
        }

        public static void CompleteOrder(Guid orderId)
        {
            PapaBobDbEntities db = new PapaBobDbEntities();

            var dbOrder = db.Orders.Where(p => p.OrderId == orderId).FirstOrDefault();
            dbOrder.Completed = true;
            db.SaveChanges();

        }
    }
}
