using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    [Serializable]
    public class Goods
    {
        private String name;
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Goods(String n)
        {
            this.name = n;
        }

        public override string ToString()
        {
            return "商品名称:" + this.name;
        }
    }
}
