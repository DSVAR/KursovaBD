using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace kursovaBD1.scripts
{
    class BDandC
    {
        static public DataGridView LCD,dds = new DataGridView();
        static public ToolStripLabel label1= new ToolStripLabel();
        static public ComboBox texb = new ComboBox();

        static public DataTable dt = new DataTable { TableName = "MY_Tbale" };
        static public SqlDataReader reader;


        static public int count;
        static public  void load()
        {
            string sql = "SELECT Name, FirstName, Street, home, flat, bought FROM allpeople";
            using (MySqlConnection connection = new MySqlConnection(Form1.connectM))
            {
                connection.Open();
               MySqlDataAdapter sqlData = new MySqlDataAdapter(sql, connection);

                MySqlCommand sql1 = new MySqlCommand(sql, connection);
                dt.Clear();

                sqlData.Fill(dt);

                LCD.Invoke((MethodInvoker)(() => LCD.DataSource = dt));


                connection.Close();

            }
           int kj = LCD.Rows.Count;
                        kj--;
                        label1.Text = kj.ToString();
        }

        static public void tex1()
        {

           

            string sql1 = "SELECT * FROM BUILDS AS b  WHERE  NOT EXISTS (SELECT a.Street, a.home, a.flat FROM allpeople a  WHERE b.Street= a.Street AND b.home=a.home AND b.flat=a.flat )";
            using (MySqlConnection connection1 = new MySqlConnection(Form1.connectM))
            {
                connection1.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql1, connection1);


                DataTable dt = new DataTable();
                dt.Clear();
                adapter.Fill(dt);
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

              
                
               
           //     MessageBox.Show(dt.Rows[0]["Street"].ToString());
             count=   dt.Rows.Count;

                for (int i = 0; i < count; i++)
                {
                    string str = dt.Rows[i]["Street"].ToString();
                    int j = i;
                    j++;
                    try
                    {
                        if (str == dt.Rows[j]["Street"].ToString())
                        {
                            dt.Rows[i].Delete();
                            j--;
                        }
                    }
                    catch { }


                }
                texb.Invoke((MethodInvoker)(() => texb.DataSource = dt));
                texb.Invoke((MethodInvoker)(() => texb.DisplayMember = "Street"));
                texb.Invoke((MethodInvoker)(() => texb.ValueMember = "Street"));


                connection1.Close();
                }
           
        }


    }



}
