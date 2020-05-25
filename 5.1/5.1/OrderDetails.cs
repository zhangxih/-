﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    [Serializable]
    public class OrderDetail
    {
        public Price p;
        public Goods g;
        private int orderID;
        private Order order;
        public string goodsname;
        public int price;
        
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
        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        [Key]
        public String Goods
        {
            get
            {
                return this.goodsname;
            }
            set
            {
                this.goodsname = value;
            }
        }
        public OrderDetail()
        {

        }
        public OrderDetail(int price, String goods, int id)
        {
            this.p = new Price(price);
            this.g = new Goods(goods);
            this.orderID = id;
            this.goodsname = goods;
            this.price = price;
        }

        public override string ToString()
        {
            return "商品名称:" + this.g.Name + "，商品金额:" + this.p.Money;
        }

        public override bool Equals(object obj)
        {
            OrderDetail o = obj as OrderDetail;
            return o != null && o.g.Name == g.Name && o.p.Money == p.Money;
        }
    }
}
