using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    [Serializable]
    public class Order:IComparable
    {
        public List<OrderDetails> details = new List<OrderDetails>();
        private int number;
        private String customer;
        private int money;
        public int Number
        {
            get
            {
                return number;
            }
        }

        public String Customer
        {
            get
            {
                return customer;
            }
        }

        public int Money
        {
            get
            {
                return money;
            }
        }

        public Order(int price, String customer, String goods, int number)
        {
            details.Add(new OrderDetails(price, goods));
            this.number = number;
            this.customer = customer;
            this.money += price;
        }

        public int CompareTo(Object obj2)
        {
            Order o = obj2 as Order;
            if (o == null)
                throw new System.ArgumentException();
            return this.Number.CompareTo(o.Number);
        }

        public void AddDetails(OrderDetails orderdetail)
        {
            foreach(OrderDetails o in details)
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
            String s = "订单编号:" + this.Number + ",客户:" + this.Customer + ",总金额:" + this.money + ";";
            foreach(OrderDetails o in details)
            {
                s += o.ToString();
            }
            return s;
        }

        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return o != null && o.Number == Number;
        }
    }
}
