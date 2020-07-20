using kursovaBD1.scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaBD1
{
    public partial class help : Form
    {
        static public int measure;
        public help()
        {
            InitializeComponent();
            change_help.Pbox = pictureBox1;
            change_help.text = text;
            change_help.text2 = text2;
            change_help.Pbox2 = pictureBox2;
            change_help.label1 = search;
            change_help.label2 = developed;
        }

        private void help_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            text.Visible = false;
            text2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            measure = 0;
            change_help.develop();
            change_help.search();
            plus();
        }

        

        private void developed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            button1.Visible = true;
            change_help.developed();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {

            if (measure == 2) { measure = 2; }
            else measure++;
            plus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (measure == 0 || measure <= 0) { measure = 0; }
            else 
            measure--;
            plus();
        }

        void plus()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            switch (measure)
            {
                case 0:
                    text2.Height = 300;
                    change_help.develop();
                 break;

                case 1:
                    text2.Height = 50;
                    change_help.search();
                break;

                case 2:
                    change_help.sort();
                break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            text.Visible = false;
            text2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            search.Visible = true;
            developed.Visible = true;
        }
    }
}
