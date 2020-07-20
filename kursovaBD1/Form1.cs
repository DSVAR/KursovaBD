using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using MySql.Data.MySqlClient;
namespace kursovaBD1
{
    public partial class Form1 : Form
    {
        static public bool prov = false;
        //static public string connect = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = SSPI";
        static public string connectM = @"server=server197.hosting.reg.ru; user=u1027450_ahmad; database=u1027450_ahmad; password=danilka07; charset=utf8";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form add = new addClients();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form addB = new Builds();
            addB.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form cl = new CLandBDs();
            cl.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form help = new help();
            help.Show();
        }
    }
}
