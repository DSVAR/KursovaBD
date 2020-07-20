using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursovaBD1.scripts
{
    class addBuilds
    {
        static public DataGridView LCD = new DataGridView();

        static public TextBox street, home, flat;
        static public ToolStripLabel label1;

        static public void addBuildss()
        {



            string sql1 = "SELECT * FROM BUILDS";
            string sql = "INSERT INTO BUILDS (Street, home, flat) VALUES (N'" + street.Text + "'" + ", " + "N'" + home.Text + "'" + ", " + "N'" + flat.Text + "'"+ ")";
            using (MySqlConnection connection = new MySqlConnection(Form1.connectM))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                int numb = command.ExecuteNonQuery();

                connection.Close();
            }
            using (MySqlConnection connection1 = new MySqlConnection(Form1.connectM))
            {
                connection1.Open();
                MySqlDataAdapter sqlData = new MySqlDataAdapter(sql1, connection1);

                DataTable dt = new DataTable();
                sqlData.Fill(dt);

                LCD.Invoke((MethodInvoker)(() => LCD.DataSource = dt));
                int kj = LCD.Rows.Count;
                kj--;
                label1.Text = kj.ToString();
                connection1.Close();
            }

        }

    }
}
