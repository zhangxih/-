using _5._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        int number = 1;
        int flag;
        int select;
        OrderService orderservice = new OrderService();
        List<Order> orders= new List<Order>();
        Order o = new Order(0, "无", "无", 0);
        public Form1()
        {   
            orders.Add(new Order(0, "无", "无", 0));
            InitializeComponent();
            OrderBindingSource.DataSource = orders;
            DetailBindingSource.DataSource = o.OrderDetails;
        }
        
        private void SelectInput_Enter(object sender, EventArgs e)
        {
            SelectInput.Text = "";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(orderservice,number);
            form2.ShowDialog();
            number++;
            OrderBindingSource.DataSource = orders;
            OrderBindingSource.ResetBindings(true);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            o = (Order)OrderBindingSource.Current;
            DetailBindingSource.DataSource = orderservice.ReturnDetails(o.OrderID);
            DetailBindingSource.ResetBindings(true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            o = (Order)OrderBindingSource.Current;
            orderservice.OrderDelete(o.OrderID);
            OrderBindingSource.DataSource = orders;
            OrderBindingSource.ResetBindings(true);
            DetailBindingSource.ResetBindings(true);
        }

        private void SelectWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectWay.Text == "编号")
                flag = 1;
            else if (SelectWay.Text == "货物")
                flag = 2;
            else if (SelectWay.Text == "客户")
                flag = 3;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (flag == 0)
                MessageBox.Show("请先选择查询方式！");
            if (flag == 1)
            {
                if (!int.TryParse(SelectInput.Text, out select))
                {
                    MessageBox.Show("请输入查询内容！");
                    return;
                }
                orders = orderservice.OrderSelect(select);
                OrderBindingSource.DataSource = orders;
                OrderBindingSource.ResetBindings(true);
            }
            if (flag == 3)
            {
                orders = orderservice.OrderSelect(SelectInput.Text);
                OrderBindingSource.DataSource = orders;
                OrderBindingSource.ResetBindings(true);
            }
            if (flag == 2)
            {
                orders = orderservice.OrderSelectByName(SelectInput.Text);
                OrderBindingSource.DataSource = orders;
                OrderBindingSource.ResetBindings(true);
            }
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            orderservice.Export();
            MessageBox.Show("导出成功！");
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            orderservice.Import();
            OrderBindingSource.DataSource = orders;
            OrderBindingSource.ResetBindings(true);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            o = (Order)OrderBindingSource.Current;
            Form form3 = new Form3(orderservice, o.OrderID);
            form3.ShowDialog();
            OrderBindingSource.DataSource = orders;
            OrderBindingSource.ResetBindings(true);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            orders = orderservice.OrderAll();
            OrderBindingSource.DataSource = orders;
            OrderBindingSource.ResetBindings(true);
        }
    }
}
