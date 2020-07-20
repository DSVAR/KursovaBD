using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using kursovaBD1.scripts;
using System.IO;


using System.Xml.Linq;

namespace kursovaBD1
{
    public partial class addClients : Form
    {

       


        static public int rows, id = 0;

        //CLDelete deles = new CLDelete();

        public addClients()
        {
            InitializeComponent();

           
            //SearchC.lab = label1;
            //SearchC.CLD = clientsDataGridView;
            //SearchC.Checktex = toolStripTextBox1;
            addclient.label1 = toolStripLabel1;
            addclient.Name = nameTextBox;
            addclient.LastN = lastNameTextBox;
            addclient.FirstN = firstNameTextBox;
            addclient.number = numberTextBox;
            addclient.LCD = clientsDataGridView;

            CLoad.LCD = clientsDataGridView;
            CLoad.label1 = toolStripLabel1;
            CLoad.tex = toolStripTextBox1;
            CLoad.Name = nameTextBox;
            CLoad.FirstN = firstNameTextBox;
            CLoad.LastN = lastNameTextBox;
            CLoad.number = numberTextBox;

            CLDelete.FirstN = firstNameTextBox;
            CLDelete.Name = nameTextBox;


            CSearch.box = toolStripTextBox2;
            CSearch.label1 = toolStripTextBox1;
            CSearch.LCD = clientsDataGridView;
        }

        private void addClients_Load(object sender, EventArgs e)
        {
            numberTextBox.Text = "+7";
            CLoad.load();
            CLoad.obj();


        }

        private void clientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CLoad.obj();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CLoad.change_();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CLoad.ChangePlus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            addclient.addclients();
            CLoad.load();
            CLoad.obj();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int ids = clientsDataGridView.CurrentCell.RowIndex;
            string ks = clientsDataGridView.Rows[ids].Cells[0].Value.ToString();
            id = int.Parse(ks);

            CLDelete.DELETE();

            CLoad.load();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            CSearch.search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            firstNameTextBox.Clear();
            numberTextBox.Text = "+7";
            lastNameTextBox.Clear();

         
        }

        private void numberTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        
    }
}
