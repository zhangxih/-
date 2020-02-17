using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace counter
{
    public partial class Form1 : Form
    {
        char symbol;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            symbol = 'a';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            symbol = 'b';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            symbol = 'c';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            symbol = 'd';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double result = 0;
            double a, b;
            if (!double.TryParse(this.textBox1.Text, out a) || !double.TryParse(this.textBox2.Text, out b))
            {
                MessageBox.Show("框中应输入数字");
                return;
            }
            switch (symbol)
            {
                case 'a':
                    result = a + b;
                    break;
                case 'b':
                    result = a - b;
                    break;
                case 'c':
                    result = a * b;
                    break;
                case 'd':
                    if (b == 0)
                    {
                        MessageBox.Show("除数不能为零");
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("请选择符号");
                    return;
            }
            this.label2.Text = result + "";
        }
    }
}
