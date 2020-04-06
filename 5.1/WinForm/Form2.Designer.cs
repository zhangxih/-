using System;

namespace WinForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateButton = new System.Windows.Forms.Button();
            this.Money = new System.Windows.Forms.TextBox();
            this.Customer = new System.Windows.Forms.TextBox();
            this.Goods = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(334, 304);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "创建订单";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // Money
            // 
            this.Money.Location = new System.Drawing.Point(139, 110);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(100, 21);
            this.Money.TabIndex = 1;
            this.Money.Text = "金额";
            this.Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Money.Enter += new System.EventHandler(this.Money_Enter);
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(318, 110);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(100, 21);
            this.Customer.TabIndex = 2;
            this.Customer.Text = "客户";
            this.Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Customer.TextChanged += new System.EventHandler(this.Customer_TextChanged);
            this.Customer.Enter += new System.EventHandler(this.Customer_Enter);
            // 
            // Goods
            // 
            this.Goods.Location = new System.Drawing.Point(515, 110);
            this.Goods.Name = "Goods";
            this.Goods.Size = new System.Drawing.Size(100, 21);
            this.Goods.TabIndex = 3;
            this.Goods.Text = "商品名称";
            this.Goods.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Goods.TextChanged += new System.EventHandler(this.Goods_TextChanged);
            this.Goods.Enter += new System.EventHandler(this.Goods_Enter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Goods);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.CreateButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox Money;
        private System.Windows.Forms.TextBox Customer;
        private System.Windows.Forms.TextBox Goods;
    }
}