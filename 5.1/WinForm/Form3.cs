using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _5._1;

namespace WinForm
{
    public partial class Form3 : Form
    {
        public OrderService orderservice = new OrderService();
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(OrderService orderservice2, int number2) : this()
        {
            this.orderservice = orderservice2;
            this.number = number2;
        }

        int number;
        int money;

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Money.Text, out money))
            {
                MessageBox.Show("框中应输入数字");
                return;
            }
            orderservice.OrderChange(number,money,Goods.Text);
            this.Hide();
        }

        private void Money_Enter(object sender, EventArgs e)
        {
            Money.Text = "";
        }

        private void Goods_Enter(object sender, EventArgs e)
        {
            Goods.Text = "";
        }
    }
}
