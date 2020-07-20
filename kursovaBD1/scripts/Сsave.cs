using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace kursovaBD.scripts
{
    class Сsave
    {
        void save()
        {
          
            using(SqlConnection connection=new SqlConnection(Form1.connect))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

            }
        }

    }
}
