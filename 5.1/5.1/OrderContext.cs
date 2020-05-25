using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    public class OrderContext:DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> Orders
        {
            get; set;
        }
        public DbSet<OrderDetail> OrderDetails
        {
            get;set;
        }
        public DbSet<Goods> Goods
        {
            get;set;
        }
    }
}
