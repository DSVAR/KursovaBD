using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace kursovaBD1.scripts
{

    class CSearch
    {
        static public ToolStripTextBox box, label1 = new ToolStripTextBox();
        static public DataGridView LCD = new DataGridView();
     

        static public void search()
        {
            if (box.TextBox.Text == "")
            {
                addclient.addclients();
                CLoad.load();
                CLoad.obj();
            }
            else { 

                string sql = "SELECT * FROM Clients WHERE FirstName LIKE N'%" + box.TextBox.Text + "'";
                using(MySqlConnection connection=new MySqlConnection(Form1.connectM))
                {
                    connection.Open();
                    MySqlDataAdapter sqlData = new MySqlDataAdapter(sql, connection);

                    DataTable dt = new DataTable();
                    sqlData.Fill(dt);

                    LCD.Invoke((MethodInvoker)(() => LCD.DataSource = dt));
                    connection.Close();
                }
                int kj = LCD.Rows.Count;
                kj--;
                label1.Text = kj.ToString();
            }
        }
    }
}
