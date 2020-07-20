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
    public partial class Builds : Form
    {
        static public int id;
        public Builds()
        {
            InitializeComponent();
            BLoad.label1 = toolStripLabel1;
            BLoad.LCD = dataGridView1;
            BLoad.tex = toolStripTextBox1;
            BLoad.street = streettextBox;
            BLoad.home = HometextBox;
            BLoad.flat =  FlattextBox;

            addBuilds.street = streettextBox;
            addBuilds.home = HometextBox;
            addBuilds.flat = FlattextBox;
            addBuilds.LCD = dataGridView1;
            addBuilds.label1 = toolStripLabel1;

            BDelete.LCD= dataGridView1;
            BDelete.street = streettextBox;
            

            BSearch.label1= toolStripTextBox1;
            BSearch.LCD = dataGridView1;
            BSearch.box = toolStripTextBox2;
        }

        private void Builds_Load(object sender, EventArgs e)
        {
            BLoad.load();

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BLoad.obj();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BLoad.change_();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BLoad.ChangePlus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            addBuilds.addBuildss();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int ids = dataGridView1.CurrentCell.RowIndex;
            string ks = dataGridView1.Rows[ids].Cells[0].Value.ToString();
            id = int.Parse(ks);

           BDelete.DELETE();

            BLoad.load();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            BSearch.search();
        }
    }
}
