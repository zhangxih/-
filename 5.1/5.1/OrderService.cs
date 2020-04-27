using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _5._1
{
    public class OrderService
    {
        public void AddOrder(Order order)
        {
            using (var db = new OrderContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }

        public List<Order> OrderAll()
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders;
                List<Order> list = new List<Order>();
                if (query != null)
                    list = query.ToList();
                return list;
            }
        }

        public List<OrderDetail> ReturnDetails(int id)
        {
            using (var db = new OrderContext())
            {
                var query = db.OrderDetails
                    .Where(d => d.OrderID == id);
                List<OrderDetail> list = query.ToList();
                return list;
            }
        }

        public List<Order> OrderSelect(int n)
        {
            using (var db = new OrderContext())
            {
                var order = db.Orders.SingleOrDefault(o => o.OrderID == n);
                List<Order> list = new List<Order>();
                if (order != null)
                    list.Add(order);
                return list;
            }
        }

        public List<Order> OrderSelect(String n)
        {
            List<Order> list = new List<Order>();
            using (var db = new OrderContext())
            {
                var query = db.Orders
                    .Where(o => o.Customer == n)
                    .OrderBy(o => o.OrderID);
                list = query.ToList();
                return list;
            }
        }

        public List<Order> OrderSelectByName(String n)
        {
            List<Order> list = new List<Order>();
            using (var db = new OrderContext())
            {
                var query1 = db.OrderDetails
                    .Where(o => o.Goods == n)
                    .OrderBy(o => o.OrderID);
                foreach(OrderDetail b in query1)
                {
                    var query2 = db.Orders.SingleOrDefault(o => o.OrderID == b.OrderID);
                    if (query2 != null&&!list.Contains(query2))
                        list.Add(query2);
                }
                return list;
            }
        }

        public void OrderDelete(int n)
        {
            using (var db = new OrderContext())
            {
                var order = db.Orders.Include("OrderDetails").SingleOrDefault(o => o.OrderID == n);
                if (order != null)
                {
                    db.Orders.Remove(order);
                    db.SaveChanges();
                }
            }
            return;
        }

        public void OrderChange(int n, int p, String g)
        {
            using (var db = new OrderContext())
            {
                var order = db.Orders.Include("OrderDetails").SingleOrDefault(o => o.OrderID == n);
                if (order != null)
                {
                    var orderdetail = new OrderDetail(p, g, n);
                    db.OrderDetails.Add(orderdetail);
                    order.Money += p;
                    db.SaveChanges();
                }
            }
            return;
        }

        public void OrderOrder()
        {
            return;
        }

        public void OrderOutput()
        {
            return;
        }

        public void Export()
        {
            using (var db = new OrderContext())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("s.xml", FileMode.Create))
                {
                    formatter.Serialize(fs, db.Orders);
                }
            }
        }

        public void Import()
        {
                BinaryFormatter formatter = new BinaryFormatter();
                List<Order> orders2;
                using (FileStream fs = new FileStream("s.xml", FileMode.Open))
                {
                    orders2 = (List<Order>)formatter.Deserialize(fs);
                }
                foreach (Order o in orders2)
                {
                    this.AddOrder(o);
                }
        }

        public bool IsNull()
        {
            using (var db = new OrderContext())
            {
                return (db.Orders==null);
            }
        }
    }
}
