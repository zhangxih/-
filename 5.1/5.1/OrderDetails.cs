using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class OrderDetails
    {
        public Price p;
        public Goods g;
        public OrderDetails(int price, String goods)
        {
            this.p = new Price(price);
            this.g = new Goods(goods);
        }

        public override string ToString()
        {
            return "商品名称:" + this.g.Name + "，商品金额:" + this.p.Money;
        }

        public override bool Equals(object obj)
        {
            OrderDetails o = obj as OrderDetails;
            return o != null && o.g.Name == g.Name && o.p.Money == p.Money;
        }
    }
}
