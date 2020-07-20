namespace kursovaBD1
{
    partial class help
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
            this.search = new System.Windows.Forms.LinkLabel();
            this.developed = new System.Windows.Forms.LinkLabel();
            this.text = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.search.Location = new System.Drawing.Point(12, 68);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(450, 45);
            this.search.TabIndex = 0;
            this.search.TabStop = true;
            this.search.Text = "Руководство по использованию";
            this.search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // developed
            // 
            this.developed.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.developed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developed.LinkArea = new System.Windows.Forms.LinkArea(0, 20);
            this.developed.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.developed.Location = new System.Drawing.Point(12, 173);
            this.developed.Name = "developed";
            this.developed.Size = new System.Drawing.Size(193, 45);
            this.developed.TabIndex = 2;
            this.developed.TabStop = true;
            this.developed.Text = "Разработчики";
            this.developed.UseCompatibleTextRendering = true;
            this.developed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.developed_LinkClicked);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(18, 34);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(64, 25);
            this.text.TabIndex = 7;
            this.text.Text = "label1";
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.text2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.Location = new System.Drawing.Point(18, 63);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(400, 47);
            this.text2.TabIndex = 9;
            this.text2.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kursovaBD1.Properties.Resources.поиск;
            this.pictureBox1.Location = new System.Drawing.Point(12, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::kursovaBD1.Properties.Resources.Untitled_1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(66, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 40);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::kursovaBD1.Properties.Resources.kisspng_next_card_android_information_shop_flyer_5b2e66449a0952_9274708815297674926309;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(406, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 40);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::kursovaBD1.Properties.Resources.kisspng_check_mark_computer_icons_sign_clip_art_mark_cross_5b1386afbffd47_2428153815280063197864;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(374, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 27);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::kursovaBD1.Properties.Resources.сортировка;
            this.pictureBox2.Location = new System.Drawing.Point(12, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 291);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 453);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.developed);
            this.Controls.Add(this.search);
            this.Name = "help";
            this.Text = "HELP";
            this.Load += new System.EventHandler(this.help_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label text;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox text2;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.LinkLabel search;
        public System.Windows.Forms.LinkLabel developed;
    }
}