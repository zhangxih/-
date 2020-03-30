using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n;
        int leng;

        private void drawbutton_Click(object sender, EventArgs e)
        {
            if ((!int.TryParse(this.depth.Text, out n)&& depth.Text != "递归深度")
                || (!int.TryParse(this.length.Text, out leng)&& length.Text != "主干长度"))
            {
                MessageBox.Show("框中应输入数字");
                return;
            }
            if (depth.Text == "递归深度")
            {
                n = 10;
            }
            if (length.Text == "主干长度")
            {
                leng = 100;
            }
            if (graphics == null)
                graphics = this.CreateGraphics();
            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        public Pen pencolor = Pens.Blue;
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(
                pencolor,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void rightlength_Scroll(object sender, EventArgs e)
        {
            per1 = (double)rightlength.Value/10;
            label1.Text = ((double)rightlength.Value / 10).ToString();
        }

        private void leftlength_Scroll(object sender, EventArgs e)
        {
            per2 = (double)leftlength.Value /10;
            label2.Text = ((double)leftlength.Value / 10).ToString();
        }

        private void rightangle_Scroll(object sender, EventArgs e)
        {
            th1 = rightangle.Value * Math.PI / 180;
            label3.Text = rightangle.Value.ToString() + "°";
        }

        private void leftangle_Scroll(object sender, EventArgs e)
        {
            th2 = leftangle.Value * Math.PI / 180;
            label4.Text = leftangle.Value.ToString() + "°";
        }

        private void color_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (color.Text)
            {
                case "蓝":
                    pencolor = Pens.Blue;
                    break;
                case "红":
                    pencolor = Pens.Red;
                    break;
                case "黄":
                    pencolor = Pens.Yellow;
                    break;
                case "绿":
                    pencolor = Pens.Green;
                    break;
            }
        }

        private void depth_Enter(object sender, EventArgs e)
        {
            depth.Text = "";
        }

        private void length_Enter(object sender, EventArgs e)
        {
            length.Text = "";
        }
    }
}
