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
    public partial class CLandBDs : Form
    {
        static public string st;
        public CLandBDs()
        {
            InitializeComponent();
            BDandC.LCD = CLdataGridView1;
            BDandC.label1 = toolStripLabel1;
            BDandC.texb = streetcomboBox1;

            changeStreet.flat = FlatComboBox;
            changeStreet.home = HomeComboBox;
            changeStreet.street = streetcomboBox1;
            changeStreet.FIO = label1;
            changeStreet.LCD = CLdataGridView1;
            changeStreet.textBoxT = toolStripTextBox1;

            updateAllP.Street = streetcomboBox1;
            updateAllP.buy = checkBox1;
            updateAllP.flat = FlatComboBox;
            updateAllP.home = HomeComboBox;
            updateAllP.LCD = CLdataGridView1;



        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void CLandBD_Load(object sender, EventArgs e)
        {
            BDandC.tex1();
            BDandC.load();
            changeStreet.changeH();
            changeStreet.obj();

        }



        private void streetcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeStreet.changeH();
        }

        private void HomeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeStreet.changeF();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            changeStreet.ChangePlus();
        }

        private void CLdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            changeStreet.obj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateAllP.update();
            BDandC.tex1();
            BDandC.load();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            changeStreet.change_();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

     
}
