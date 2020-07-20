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
    class BDelete
    {
        static public DataGridView LCD = new DataGridView();
        static public TextBox street = new TextBox();
        static public int ID;

        addclient add = new addclient();
        static public void DELETE()
        {

            ID = Builds.id;
            string del = "DELETE FROM BUILDS WHERE Street LIKE N'" + street.Text + "'" + "AND ID LIKE'" + ID + "'";
            using (MySqlConnection connection = new MySqlConnection(Form1.connectM))
            {
                connection.Open();
                MySqlCommand sql = new MySqlCommand(del, connection);
                sql.ExecuteNonQuery();

                connection.Close();
            }
        }

    }
}

