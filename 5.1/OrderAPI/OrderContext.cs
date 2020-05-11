using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _5._1;

namespace OrderAPI
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            this.Database.EnsureCreated(); 
        }

        public DbSet<Order> Orders
        {
            get; set;
        }
        public DbSet<OrderDetail> OrderDetails
        {
            get; set;
        }
    }
}
