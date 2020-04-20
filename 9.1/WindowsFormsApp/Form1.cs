using _9._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        SimpleCrawler simpleCrawler = new SimpleCrawler();
        public Form1()
        {
            InitializeComponent();
            UrlBindingSource.DataSource = simpleCrawler.used;
            this.timer1.Start();
        }

        private void StartUrl_Enter(object sender, EventArgs e)
        {
            StartUrl.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UrlBindingSource.ResetBindings(true);
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            string startUrl = StartUrl.Text;
            simpleCrawler.urls.Add(startUrl, false);//加入初始页面
            simpleCrawler.nexturls.Add(startUrl, false);
            simpleCrawler.Crawl();
        }
    }
}
