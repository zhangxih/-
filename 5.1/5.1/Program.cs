using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderservice = new OrderService();
            String s="";
            while (true)
            {
                Console.WriteLine("请输入你的操作");
                s = Console.ReadLine();
                if (s == "add")
                {
                    Console.WriteLine("请输入订单信息");
                    int price; String customer; String goods; int number;
                    price = int.Parse(Console.ReadLine());
                    customer = Console.ReadLine();
                    goods = Console.ReadLine();
                    number = int.Parse(Console.ReadLine());
                    orderservice.AddOrder(new Order(price, customer, goods, number));
                }
                if (s == "select")
                {
                    Console.WriteLine("请输入查询方式");
                    s = Console.ReadLine();
                    if (s == "number")
                    {
                        Console.WriteLine("请输入查询信息");
                        int n = int.Parse(Console.ReadLine());
                        List<Order> list = orderservice.OrderSelect(n);
                        foreach(Order o in list)
                        {
                            Console.WriteLine(o.ToString());
                        }
                    }
                    else if (s == "customer")
                    {
                        Console.WriteLine("请输入查询信息");
                        s = Console.ReadLine();
                        List<Order> list = orderservice.OrderSelect(s);
                        foreach (Order o in list)
                        {
                            Console.WriteLine(o.ToString());
                        }
                    }
                    else if (s == "goods")
                    {
                        Console.WriteLine("请输入查询信息");
                        s = Console.ReadLine();
                        List<Order> list = orderservice.OrderSelectByName(s);
                        foreach (Order o in list)
                        {
                            Console.WriteLine(o.ToString());
                        }
                    }
                }
                else if(s == "delete")
                {
                    Console.WriteLine("请输入要删除的订单编号");
                    int n = int.Parse(Console.ReadLine());
                    orderservice.OrderDelete(n);
                }
                else if (s == "change")
                {
                    Console.WriteLine("请输入要修改的订单编号");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入要修改的订单信息");
                    int p = int.Parse(Console.ReadLine());
                    s = Console.ReadLine();
                    orderservice.OrderChange(n, p, s);
                }
                else if (s == "order")
                {
                    orderservice.OrderOrder();
                }
                else if (s == "output")
                {
                    orderservice.OrderOutput();
                }
            }
        }
    }
}
