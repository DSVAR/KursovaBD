using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using MySql.Data.MySqlClient;

namespace kursovaBD1.scripts
{
    class BLoad
    {
        static public DataGridView LCD = new DataGridView();
        static public ToolStripLabel label1 = new ToolStripLabel();
        static public ToolStripTextBox tex = new ToolStripTextBox();

        static public TextBox home, street, flat;

      static public  DataTable dt = new DataTable {TableName= "MY_Tbale" };
        static public SqlDataReader reader;
        static public int js;

        static public void load()
        {
            string sql1 = "SELECT * FROM BUILDS";
            using (MySqlConnection connection1 = new MySqlConnection(Form1.connectM))
            {
                connection1.Open();
                MySqlDataAdapter sqlData = new MySqlDataAdapter(sql1, connection1);

                dt.Clear();
                sqlData.Fill(dt);

                LCD.Invoke((MethodInvoker)(() => LCD.DataSource = dt));

               
               // dt.Load(reader);
                connection1.Close();

            }
            int kj = LCD.Rows.Count;
            kj--;
            label1.Text = kj.ToString();


        }

        static public void obj()
        {
            try
            {

                js = LCD.CurrentCell.RowIndex;
                js++;
                tex.TextBox.Invoke((MethodInvoker)(() => tex.TextBox.Text = js.ToString()));



                string ks = tex.TextBox.Text;
                int row_ind = int.Parse(ks);
                int select = LCD.CurrentCell.RowIndex;
                row_ind--;

                LCD.Rows[select].Selected = false;
                LCD.Rows[row_ind].Selected = true;

                string st = LCD.Rows[row_ind].Cells[1].Value.ToString();
                string homes = LCD.Rows[row_ind].Cells[2].Value.ToString();
                string flats = LCD.Rows[row_ind].Cells[3].Value.ToString();
               

                street.Invoke((MethodInvoker)(() => street.Text = st));
                home.Invoke((MethodInvoker)(() => home.Text = homes));
                flat.Invoke((MethodInvoker)(() => flat.Text = flats));
             }
            catch { }

        }

        static public void change_()
        {

            js = LCD.CurrentCell.RowIndex;

            tex.TextBox.Invoke((MethodInvoker)(() => tex.TextBox.Text = js.ToString()));

            string ks = tex.TextBox.Text;
            int row_ind = int.Parse(ks);
            int select = LCD.CurrentCell.RowIndex;

            row_ind--;

            if (row_ind == 0 || row_ind <= 0)
            {
                row_ind = 0;
            }



            LCD.Invoke((MethodInvoker)(() => LCD.CurrentCell = LCD.Rows[row_ind].Cells[1]));
            LCD.Rows[select].Selected = false;
            LCD.Rows[row_ind].Selected = true;

            string st = LCD.Rows[row_ind].Cells[1].Value.ToString();
            string homes = LCD.Rows[row_ind].Cells[2].Value.ToString();
            string flats = LCD.Rows[row_ind].Cells[3].Value.ToString();


            street.Invoke((MethodInvoker)(() => street.Text = st));
            home.Invoke((MethodInvoker)(() => home.Text = homes));
            flat.Invoke((MethodInvoker)(() => flat.Text = flats));

        }

        static public void ChangePlus()
        {
            try
            {
                js = LCD.CurrentCell.RowIndex;
                js += 2;
                tex.TextBox.Invoke((MethodInvoker)(() => tex.TextBox.Text = js.ToString()));


                string ks = tex.TextBox.Text;
                int row_ind = int.Parse(ks);
                int select = LCD.CurrentCell.RowIndex;
                row_ind--;

                LCD.Invoke((MethodInvoker)(() => LCD.CurrentCell = LCD.Rows[row_ind].Cells[1]));
                LCD.Rows[select].Selected = false;
                LCD.Rows[row_ind].Selected = true;

                string st = LCD.Rows[row_ind].Cells[1].Value.ToString();
                string homes = LCD.Rows[row_ind].Cells[2].Value.ToString();
                string flats = LCD.Rows[row_ind].Cells[3].Value.ToString();


                street.Invoke((MethodInvoker)(() => street.Text = st));
                home.Invoke((MethodInvoker)(() => home.Text = homes));
                flat.Invoke((MethodInvoker)(() => flat.Text = flats));
            }
            catch
            {
                MessageBox.Show("Впереди никого нет");
            }
        }



    }


}
