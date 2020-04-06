namespace WinForm
{
    partial class Form3
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.Money = new System.Windows.Forms.TextBox();
            this.Goods = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(335, 270);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 0;
            this.ChangeButton.Text = "添加明细";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // Money
            // 
            this.Money.Location = new System.Drawing.Point(208, 128);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(100, 21);
            this.Money.TabIndex = 1;
            this.Money.Text = "金额";
            this.Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Money.Enter += new System.EventHandler(this.Money_Enter);
            // 
            // Goods
            // 
            this.Goods.Location = new System.Drawing.Point(433, 128);
            this.Goods.Name = "Goods";
            this.Goods.Size = new System.Drawing.Size(100, 21);
            this.Goods.TabIndex = 2;
            this.Goods.Text = "货物";
            this.Goods.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Goods.Enter += new System.EventHandler(this.Goods_Enter);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Goods);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.ChangeButton);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox Money;
        private System.Windows.Forms.TextBox Goods;
    }
}