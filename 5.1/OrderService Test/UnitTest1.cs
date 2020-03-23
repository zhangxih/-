using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5._1;

namespace OrderService_Test
{
    [TestClass]
    public class OrderServiceTest
    {
        OrderService orderservice = new OrderService();
        [TestMethod]
        public void AddOrderTest()
        {
            orderservice.AddOrder(new Order(12, "a", "b", 1));
            orderservice.AddOrder(new Order(12, "a", "b", 1));
            Assert.IsFalse(orderservice.IsNull());
        }

        [TestMethod]
        public void OrderSelectTest()
        {
            orderservice.AddOrder(new Order(12, "a", "b", 1));
            orderservice.OrderSelect(1);
            orderservice.OrderSelect(2);
            orderservice.OrderSelect("a");
            orderservice.OrderSelect("b");
            CollectionAssert.Equals(orderservice.OrderSelect(1), orderservice.OrderSelect("a"));
        }

        [TestMethod]
        public void OrderSelectByNameTest()
        {
            orderservice.AddOrder(new Order(12, "a", "b", 1));
            orderservice.OrderSelectByName("b");
            Assert.IsNotNull(orderservice.OrderSelectByName("b"));
        }

        [TestMethod]
        public void OrderDeleteTest()
        {
            orderservice.AddOrder(new Order(12, "a", "b", 1));
            orderservice.OrderDelete(1);
            orderservice.OrderDelete(2);
            Assert.IsTrue(orderservice.IsNull());
        }

        [TestMethod]
        public void OrderChangeTest()
        {
            orderservice.AddOrder(new Order(12, "a", "b", 1));
            orderservice.OrderChange(1, 13, "c");
            orderservice.OrderChange(1, 13, "c");
            Assert.IsFalse(orderservice.IsNull());
        }

        [TestMethod]
        public void OrderOrderTest()
        {
            orderservice.AddOrder(new Order(12, "a", "b", 1));
            orderservice.AddOrder(new Order(13, "c", "d", 2));
            orderservice.AddOrder(new Order(11, "e", "f", 3));
            orderservice.OrderOrder();
            Assert.IsFalse(orderservice.IsNull());
        }

        [TestMethod]
        public void OrderOutputTest()
        {
            orderservice.AddOrder(new Order(12, "a", "b", 1));
            orderservice.OrderOutput();
            Assert.IsFalse(orderservice.IsNull());
        }

        [TestMethod]
        public void ExportTest()
        {
            orderservice.AddOrder(new Order(12, "a", "b", 1));
            orderservice.Export();
            Assert.IsFalse(orderservice.IsNull());
        }

        [TestMethod]
        public void ImportTest()
        {
            orderservice.AddOrder(new Order(12, "a", "b", 1));
            orderservice.AddOrder(new Order(13, "c", "d", 2));
            orderservice.Export();
            orderservice.OrderDelete(1);
            orderservice.Import();
            Assert.IsFalse(orderservice.IsNull());
        }

        [TestCleanup]
        public void Clean()
        {
            orderservice.OrderDelete(1);
            orderservice.OrderDelete(2);
            orderservice.OrderDelete(3);
        }
    }
}
