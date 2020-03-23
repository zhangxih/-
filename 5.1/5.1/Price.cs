using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    [Serializable]
    public class Price
    {
        private int money;
        public int Money
        {
            get
            {
                return money;
            }
        }

        public Price(int m)
        {
            this.money = m;
        }

        public override String ToString()
        {
            return "金额:" + this.money;
        }
    }
}
