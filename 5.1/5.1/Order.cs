using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    [Serializable]
    public class Order:IComparable
    {
        public List<OrderDetail> details = new List<OrderDetail>();
        private int orderID;
        private String customer;
        private int money;
        public List<OrderDetail> OrderDetails
        {
            get
            {
                return details;
            }
            set { }
        }
        [Key]
        public int OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
        }

        public String Customer
        {
            get
            {
                return customer;
            }
            set
            {
                customer = value;
            }
        }

        public int Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
        public Order()
        {

        }
        public Order(int price, String customer, String goods, int number)
        {
            details.Add(new OrderDetail(price, goods, number));
            this.orderID = number;
            this.customer = customer;
            this.money += price;
        }

        public int CompareTo(Object obj2)
        {
            Order o = obj2 as Order;
            if (o == null)
                throw new System.ArgumentException();
            return this.OrderID.CompareTo(o.OrderID);
        }

        public void AddDetails(OrderDetail orderdetail)
        {
            foreach(OrderDetail o in details)
            {
                if (orderdetail.Equals(o))
                {
                    Console.WriteLine("同一订单不能输入相同的明细！");
                    return;
                }
                details.Add(orderdetail);
                this.money += orderdetail.p.Money;
                return;
            }
        }

        public override string ToString()
        {
            String s = "订单编号:" + this.OrderID + ",客户:" + this.Customer + ",总金额:" + this.money + ";";
            foreach(OrderDetail o in details)
            {
                s += o.ToString();
            }
            return s;
        }

        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return o != null && o.OrderID == OrderID;
        }
    }
}
