using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace kursovaBD.scripts
{
    class addclient
    {
        static public addClients adC = new addClients();
        static public DataGridView LCD = new DataGridView();

        static public TextBox Name, FirstN, LastN, number;
        static public ToolStripLabel label1;
      static public  void addclients()
        {

           

            string sql1 = "SELECT Name, FirstName,LastName,number FROM Clients";
            string sql = "INSERT INTO Clients (Name, FirstName, LastName, number) VALUES (N'"  + Name.Text + "'" + ", " + "N'" + FirstN.Text + "'" + ", " + "N'" + LastN.Text + "'" + ", " + number.Text + ")";
            using (SqlConnection connection= new SqlConnection(Form1.connect))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql,connection);
                int numb = command.ExecuteNonQuery();
              
                connection.Close();
            }
             using(SqlConnection connection1=new SqlConnection(Form1.connect))
            {
                connection1.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter(sql1,connection1);

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
