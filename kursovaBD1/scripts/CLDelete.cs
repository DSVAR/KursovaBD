using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace kursovaBD1.scripts
{
    class CLDelete
    {
        static public DataGridView LCD = new DataGridView();
        static public TextBox FirstN, Name= new TextBox();
        static public int ID;

        addclient add = new addclient();
        static public void DELETE()
        {
     

            ID = addClients.id;
            string del = "DELETE FROM Clients WHERE FirstName LIKE N'" + FirstN.Text + "'" + "AND ID LIKE'" + ID + "'";
            string dels = "DELETE FROM allpeople WHERE FirstName LIKE N'" + FirstN.Text + "'" + "AND Name LIKE N'" + Name.Text + "'";
            using (MySqlConnection connection = new MySqlConnection(Form1.connectM))
            {
                connection.Open();
                MySqlCommand sql = new MySqlCommand(del, connection);
                sql.ExecuteNonQuery();

                connection.Close();
            }

            using (MySqlConnection connection1=new MySqlConnection(Form1.connectM))
            {
                connection1.Open();
                MySqlCommand sql = new MySqlCommand(dels, connection1);
              sql.ExecuteNonQuery();
              
                connection1.Close();
            }
        }

    }
}
