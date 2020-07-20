using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kursovaBD.scripts
{
    class CLDelete
    {
        static public DataGridView LCD = new DataGridView();
        static public TextBox FirstN= new TextBox();
        static public int ID;
        
        addclient add = new addclient();
        static public void DELETE()
        {

            ID = addClients.id;
            string del = "DELETE FROM Clients WHERE FirstName LIKE N'" + FirstN.Text + "'" + "AND ID LIKE'" + ID + "'";
            using (SqlConnection connection=new SqlConnection(Form1.connect))
            {
                connection.Open();
                SqlCommand sql = new SqlCommand(del, connection);
                 sql.ExecuteNonQuery();
              
                connection.Close();
            }
        }

    }
}
