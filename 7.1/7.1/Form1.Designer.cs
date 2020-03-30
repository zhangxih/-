namespace _7._1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.drawbutton = new System.Windows.Forms.Button();
            this.depth = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.rightlength = new System.Windows.Forms.TrackBar();
            this.leftlength = new System.Windows.Forms.TrackBar();
            this.rightangle = new System.Windows.Forms.TrackBar();
            this.leftangle = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rightlength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftlength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftangle)).BeginInit();
            this.SuspendLayout();
            // 
            // drawbutton
            // 
            this.drawbutton.Location = new System.Drawing.Point(703, 24);
            this.drawbutton.Name = "drawbutton";
            this.drawbutton.Size = new System.Drawing.Size(75, 23);
            this.drawbutton.TabIndex = 0;
            this.drawbutton.Text = "画图(&d)";
            this.drawbutton.UseVisualStyleBackColor = true;
            this.drawbutton.Click += new System.EventHandler(this.drawbutton_Click);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(703, 73);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(75, 21);
            this.depth.TabIndex = 1;
            this.depth.Text = "递归深度";
            this.depth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.depth.TextChanged += new System.EventHandler(this.depth_TextChanged);
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(703, 118);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(75, 21);
            this.length.TabIndex = 2;
            this.length.Text = "主干长度";
            this.length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.length.TextChanged += new System.EventHandler(this.length_TextChanged);
            // 
            // rightlength
            // 
            this.rightlength.Location = new System.Drawing.Point(703, 155);
            this.rightlength.Name = "rightlength";
            this.rightlength.Size = new System.Drawing.Size(75, 45);
            this.rightlength.TabIndex = 3;
            this.rightlength.Scroll += new System.EventHandler(this.rightlength_Scroll);
            // 
            // leftlength
            // 
            this.leftlength.Location = new System.Drawing.Point(703, 207);
            this.leftlength.Name = "leftlength";
            this.leftlength.Size = new System.Drawing.Size(75, 45);
            this.leftlength.TabIndex = 4;
            this.leftlength.Scroll += new System.EventHandler(this.leftlength_Scroll);
            // 
            // rightangle
            // 
            this.rightangle.Location = new System.Drawing.Point(703, 268);
            this.rightangle.Maximum = 180;
            this.rightangle.Name = "rightangle";
            this.rightangle.Size = new System.Drawing.Size(75, 45);
            this.rightangle.TabIndex = 5;
            this.rightangle.Scroll += new System.EventHandler(this.rightangle_Scroll);
            // 
            // leftangle
            // 
            this.leftangle.Location = new System.Drawing.Point(703, 319);
            this.leftangle.Maximum = 180;
            this.leftangle.Name = "leftangle";
            this.leftangle.Size = new System.Drawing.Size(75, 45);
            this.leftangle.TabIndex = 6;
            this.leftangle.Scroll += new System.EventHandler(this.leftangle_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "右分支长度比";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "左分支长度比";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "右分支角度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "左分支角度";
            // 
            // color
            // 
            this.color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "蓝",
            "红",
            "黄",
            "绿"});
            this.color.Location = new System.Drawing.Point(703, 382);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(75, 20);
            this.color.TabIndex = 11;
            this.color.SelectedIndexChanged += new System.EventHandler(this.color_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(716, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "画笔颜色";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.color);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftangle);
            this.Controls.Add(this.rightangle);
            this.Controls.Add(this.leftlength);
            this.Controls.Add(this.rightlength);
            this.Controls.Add(this.length);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.drawbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rightlength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftlength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftangle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawbutton;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TrackBar rightlength;
        private System.Windows.Forms.TrackBar leftlength;
        private System.Windows.Forms.TrackBar rightangle;
        private System.Windows.Forms.TrackBar leftangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.Label label5;
    }
}

