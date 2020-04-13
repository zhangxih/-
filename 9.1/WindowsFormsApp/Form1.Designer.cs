namespace WindowsFormsApp
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartUrl = new System.Windows.Forms.TextBox();
            this.BeginButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UrlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.usedurlsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartUrl);
            this.groupBox1.Controls.Add(this.BeginButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主菜单";
            // 
            // StartUrl
            // 
            this.StartUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartUrl.Location = new System.Drawing.Point(78, 17);
            this.StartUrl.Name = "StartUrl";
            this.StartUrl.Size = new System.Drawing.Size(719, 21);
            this.StartUrl.TabIndex = 1;
            this.StartUrl.Text = "http://www.cnblogs.com/dstang2000/";
            this.StartUrl.Enter += new System.EventHandler(this.StartUrl_Enter);
            // 
            // BeginButton
            // 
            this.BeginButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BeginButton.Location = new System.Drawing.Point(3, 17);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(75, 44);
            this.BeginButton.TabIndex = 0;
            this.BeginButton.Text = "开始";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usedurlsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.UrlBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(797, 386);
            this.dataGridView1.TabIndex = 1;
            // 
            // UrlBindingSource
            // 
            this.UrlBindingSource.DataSource = typeof(_9._1.Url);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // usedurlsDataGridViewTextBoxColumn
            // 
            this.usedurlsDataGridViewTextBoxColumn.DataPropertyName = "Usedurls";
            this.usedurlsDataGridViewTextBoxColumn.HeaderText = "Usedurls";
            this.usedurlsDataGridViewTextBoxColumn.Name = "usedurlsDataGridViewTextBoxColumn";
            this.usedurlsDataGridViewTextBoxColumn.ReadOnly = true;
            this.usedurlsDataGridViewTextBoxColumn.Width = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrlBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox StartUrl;
        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource UrlBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usedurlsDataGridViewTextBoxColumn;
    }
}

