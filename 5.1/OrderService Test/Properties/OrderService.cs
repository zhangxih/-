using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _5._1
{
    class OrderService
    {
        List<Order> orders = new List<Order>();
        public void AddOrder(Order order)
        {
            foreach(Order o in orders)
            {
                if (order.Equals(o))
                {
                    Console.WriteLine("不能添加相同的订单！");
                    return;
                }
            }
            orders.Add(order);
        }

        public bool IsNull()
        {
            return (this.orders.Count == 0);
        }

        public List<Order> OrderSelect(int n)
        {
            var order = from o in orders
                        where o.OrderID == n
                        select o;
            List<Order> list = order.ToList();
            return list;
        }

        public List<Order> OrderSelect(String n)
        {
            var order = from o in orders
                        where o.Customer == n
                        orderby o.Money
                        select o;
            List<Order> list = order.ToList();
            return list;
        }

        public List<Order> OrderSelectByName(String n)
        {
            List<Order> list = new List<Order>();
            foreach (Order o in orders)
            {
                var t = from de in o.details
                        where de.g.Name == n
                        select de;
                if (t.First() != null)
                    list.Add(o);
            }
            var order = from o in list
                        orderby o.Money
                        select o;
            list = order.ToList();
            return list;
        }

        public void OrderDelete(int n)
        {
            for (int i = orders.Count - 1; i >= 0; i--)
            {
                if (orders[i].OrderID == n)
                {
                    orders.Remove(orders[i]);
                    Console.WriteLine("删除成功！");
                    return;
                }
            }
            Console.WriteLine("删除失败！");
            return;
        }

        public void OrderChange(int n, int p, String g)
        {
            for (int i = orders.Count - 1; i >= 0; i--)
            {
                if (orders[i].OrderID == n)
                {
                    orders[i].AddDetails(new OrderDetail(p,g, n));
                    Console.WriteLine("修改成功！");
                    return;
                }
            }
            Console.WriteLine("不存在订单！");
            return;
        }

        public void OrderOrder()
        {
            orders.Sort();
            foreach(Order o in orders)
            {
                Console.WriteLine(o.ToString());
            }
        }

        public void OrderOutput()
        {
            foreach (Order o in orders)
            {
                Console.WriteLine(o.ToString());
            }
        }

        public void Export()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                formatter.Serialize(fs, orders);
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
            foreach(Order o in orders2)
            {
                this.AddOrder(o);
            }
        }
    }
}
