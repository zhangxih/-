using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using _5._1;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form2 : Form
    {
        public OrderService orderservice = new OrderService();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(OrderService orderservice2,int number2) : this()
        {
            this.orderservice = orderservice2;
            this.number = number2;
        }
        int money;
        String customer;
        String goods;
        int number;
        private void Customer_TextChanged(object sender, EventArgs e)
        {
            customer = Customer.Text;
        }

        private void Goods_TextChanged(object sender, EventArgs e)
        {
            goods = Goods.Text;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Money.Text, out money))
            {
                MessageBox.Show("框中应输入数字");
                return;
            }
            orderservice.AddOrder(new Order(money, customer, goods, number));
            this.Hide();
        }

        private void Money_Enter(object sender, EventArgs e)
        {
            Money.Text = "";
        }

        private void Customer_Enter(object sender, EventArgs e)
        {
            Customer.Text = "";
        }

        private void Goods_Enter(object sender, EventArgs e)
        {
            Goods.Text = "";
        }
    }
}
