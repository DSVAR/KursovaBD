namespace kursovaBD1
{
    partial class Builds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Builds));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.FlattextBox = new System.Windows.Forms.TextBox();
            this.HometextBox = new System.Windows.Forms.TextBox();
            this.streettextBox = new System.Windows.Forms.TextBox();
            this.streetlabel = new System.Windows.Forms.Label();
            this.Homelabel = new System.Windows.Forms.Label();
            this.Flatlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Street,
            this.Home,
            this.Flat});
            this.dataGridView1.Location = new System.Drawing.Point(26, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(490, 257);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Street
            // 
            this.Street.DataPropertyName = "Street";
            this.Street.HeaderText = "Улица";
            this.Street.Name = "Street";
            this.Street.Width = 150;
            // 
            // Home
            // 
            this.Home.DataPropertyName = "home";
            this.Home.HeaderText = "Дом";
            this.Home.Name = "Home";
            this.Home.Width = 150;
            // 
            // Flat
            // 
            this.Flat.DataPropertyName = "flat";
            this.Flat.HeaderText = "Квартира";
            this.Flat.Name = "Flat";
            this.Flat.Width = 150;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripTextBox2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(675, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(20, 23);
            this.toolStripTextBox1.Text = "1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 20);
            this.toolStripLabel1.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // FlattextBox
            // 
            this.FlattextBox.Location = new System.Drawing.Point(81, 116);
            this.FlattextBox.Name = "FlattextBox";
            this.FlattextBox.Size = new System.Drawing.Size(100, 20);
            this.FlattextBox.TabIndex = 2;
            // 
            // HometextBox
            // 
            this.HometextBox.Location = new System.Drawing.Point(81, 77);
            this.HometextBox.Name = "HometextBox";
            this.HometextBox.Size = new System.Drawing.Size(100, 20);
            this.HometextBox.TabIndex = 3;
            // 
            // streettextBox
            // 
            this.streettextBox.Location = new System.Drawing.Point(81, 38);
            this.streettextBox.Name = "streettextBox";
            this.streettextBox.Size = new System.Drawing.Size(100, 20);
            this.streettextBox.TabIndex = 4;
            // 
            // streetlabel
            // 
            this.streetlabel.AutoSize = true;
            this.streetlabel.Location = new System.Drawing.Point(23, 41);
            this.streetlabel.Name = "streetlabel";
            this.streetlabel.Size = new System.Drawing.Size(42, 13);
            this.streetlabel.TabIndex = 5;
            this.streetlabel.Text = "Улица:";
            // 
            // Homelabel
            // 
            this.Homelabel.AutoSize = true;
            this.Homelabel.Location = new System.Drawing.Point(23, 80);
            this.Homelabel.Name = "Homelabel";
            this.Homelabel.Size = new System.Drawing.Size(33, 13);
            this.Homelabel.TabIndex = 6;
            this.Homelabel.Text = "Дом:";
            // 
            // Flatlabel
            // 
            this.Flatlabel.AutoSize = true;
            this.Flatlabel.Location = new System.Drawing.Point(23, 119);
            this.Flatlabel.Name = "Flatlabel";
            this.Flatlabel.Size = new System.Drawing.Size(58, 13);
            this.Flatlabel.TabIndex = 7;
            this.Flatlabel.Text = "Квартира:";
            // 
            // Builds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.Flatlabel);
            this.Controls.Add(this.Homelabel);
            this.Controls.Add(this.streetlabel);
            this.Controls.Add(this.streettextBox);
            this.Controls.Add(this.HometextBox);
            this.Controls.Add(this.FlattextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Builds";
            this.Text = "Builds";
            this.Load += new System.EventHandler(this.Builds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn Home;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label streetlabel;
        private System.Windows.Forms.Label Homelabel;
        private System.Windows.Forms.Label Flatlabel;
        public System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.TextBox FlattextBox;
        public System.Windows.Forms.TextBox HometextBox;
        public System.Windows.Forms.TextBox streettextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}