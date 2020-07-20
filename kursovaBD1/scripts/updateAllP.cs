using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursovaBD1.scripts
{
    class updateAllP
    {
        static public DataGridView LCD = new DataGridView();
        static public ComboBox Street, home, flat = new ComboBox();
        static public CheckBox buy;
       static public void update()
        {
            string Name, Firstname,bought;
            int select = LCD.CurrentCell.RowIndex;
            Firstname = LCD.Rows[select].Cells[1].Value.ToString();
            Name= LCD.Rows[select].Cells[0].Value.ToString();
            bought = buy.Checked.ToString();

            string sql = "Update allpeople SET Street= '"+Street.Text+"', home='"+home.Text+"', flat='"+flat.Text+"', bought='"+bought+"' where Firstname='"+Firstname+"' and Name='"+Name+"'";
      //      string sql1 = "Update allpeople SET Street= N'арвар', home='21', flat='222' where Firstname=N'Букин' and Name=N'Генадий'";
        //  MessageBox.Show(Firstname+" "+ Name);
            using(MySqlConnection connection =new MySqlConnection(Form1.connectM))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
               command.ExecuteNonQuery();
                connection.Close();
            }

        }

    }
}
