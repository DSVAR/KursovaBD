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
    class addclient
    {
        static public DataGridView LCD = new DataGridView();

        static public TextBox Name, FirstN, LastN, number;
        static public ToolStripLabel label1;

        static public void addclients()
        {


            string sqlALpeople = "INSERT INTO allpeople (Name, FirstName) VALUES ('" + Name.Text + "'" + ", " + "'" + FirstN.Text + "')";
        //    string sql1 = "SELECT Name, FirstName,LastName,number FROM Clients";
        //    string sql = "INSERT INTO Clients (Name, FirstName, LastName, number) VALUES ('" + Name.Text + "'" + ", " + "'" + FirstN.Text + "'" + ", " + "'" + LastN.Text + "'" + ", " + number.Text + ")";
         string   sql= "INSERT INTO Clients(Name, FirstName, LastName, number) VALUES('"+Name.Text+"', '"+FirstN.Text+"', '"+LastN.Text+"', '"+number.Text+"')";
            using (MySqlConnection connection= new MySqlConnection(Form1.connectM))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql,connection);
                int numb = command.ExecuteNonQuery();
                connection.Close();
            }
            
         
            using (MySqlConnection connection2=new MySqlConnection(Form1.connectM))
            {
                connection2.Open();
                MySqlCommand command = new MySqlCommand(sqlALpeople, connection2);
                command.ExecuteNonQuery();

                connection2.Close();
            }

            //using (SqlConnection connection1 = new SqlConnection(Form1.connect))
            //{
            //    connection1.Open();
            //    SqlDataAdapter sqlData = new SqlDataAdapter(sql1, connection1);

            //    DataTable dt = new DataTable();
            //    sqlData.Fill(dt);

            //    LCD.Invoke((MethodInvoker)(() => LCD.DataSource = dt));
            //    int kj = LCD.Rows.Count;
            //    kj--;
            //    label1.Text = kj.ToString();
            //    connection1.Close();
            //}

        }
    }
}
