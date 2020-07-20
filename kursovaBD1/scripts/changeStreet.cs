using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace kursovaBD1.scripts
{
    class changeStreet
    {
        static public ComboBox street, home, flat = new ComboBox();
        static public Label FIO=new Label();
        static public DataGridView LCD = new DataGridView();
        static public ToolStripTextBox textBoxT = new ToolStripTextBox();
        


        static public int js;
        static public void changeH()
        {
            string sql = "SELECT DISTINCT home FROM BUILDS WHERE Street LIKE N'" + street.Text+"'";
            using(MySqlConnection connection=new MySqlConnection(Form1.connectM))
            {
                connection.Open();
                MySqlDataAdapter sqlData = new MySqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();
                dt.Clear();
                sqlData.Fill(dt);

                home.Invoke((MethodInvoker)(() => home.DataSource = dt));
                home.Invoke((MethodInvoker)(() => home.DisplayMember = "home"));
                home.Invoke((MethodInvoker)(() => home.ValueMember="home"));
                connection.Close();
            }
        //    MessageBox.Show(street.Text);
        } 


        static public void changeF()
        {
            string sql1 = "SELECT flat FROM BUILDS WHERE Street LIKE N'" + street.Text + "' AND home LIKE N'"+home.Text+"'" ;
            using (MySqlConnection connection1 = new MySqlConnection(Form1.connectM))
            {
                connection1.Open();
                MySqlDataAdapter sqlData = new MySqlDataAdapter(sql1, connection1);

                DataTable ds = new DataTable();
                ds.Clear();
                sqlData.Fill(ds);

                flat.Invoke((MethodInvoker)(() => flat.DataSource = ds));
                flat.Invoke((MethodInvoker)(() => flat.DisplayMember = "flat"));
                flat.Invoke((MethodInvoker)(() => flat.ValueMember = "flat"));
                connection1.Close();
            }
        }

        static public void ChangePlus()
        {
        
            try
            {
                js = LCD.CurrentCell.RowIndex;
               
                js += 2;
               textBoxT.TextBox.Invoke((MethodInvoker)(() => textBoxT.TextBox.Text = js.ToString()));


                string ks = textBoxT.TextBox.Text;
                

                int row_ind = int.Parse(ks);
                int select = LCD.CurrentCell.RowIndex;
                row_ind--;

                LCD.Invoke((MethodInvoker)(() => LCD.CurrentCell = LCD.Rows[row_ind].Cells[1]));
                LCD.Rows[select].Selected = false;
                LCD.Rows[row_ind].Selected = true;

                string name = LCD.Rows[row_ind].Cells[0].Value.ToString();
                string First = LCD.Rows[row_ind].Cells[1].Value.ToString();

                FIO.Text = name + " " + First + ":";


            }
            catch
            {
                MessageBox.Show("Впереди никого нет");
            }
        }

        static public void change_()
        {

            js = LCD.CurrentCell.RowIndex;

            textBoxT.TextBox.Invoke((MethodInvoker)(() => textBoxT.TextBox.Text = js.ToString()));

            string ks = textBoxT.TextBox.Text;
            int row_ind = int.Parse(ks);
            int select = LCD.CurrentCell.RowIndex;

            row_ind--;

            if (row_ind == 0 || row_ind <= 0)
            {
                row_ind = 0;
                textBoxT.TextBox.Invoke((MethodInvoker)(() => textBoxT.TextBox.Text = "1"));
            }



            LCD.Invoke((MethodInvoker)(() => LCD.CurrentCell = LCD.Rows[row_ind].Cells[0]));
            LCD.Rows[select].Selected = false;
            LCD.Rows[row_ind].Selected = true;

            string name = LCD.Rows[row_ind].Cells[0].Value.ToString();
            string First = LCD.Rows[row_ind].Cells[1].Value.ToString();

            FIO.Text = name + " " + First + ":";

        }

        static public void obj()
        {
            try
            {

                js = LCD.CurrentCell.RowIndex;
                js++;
                textBoxT.TextBox.Invoke((MethodInvoker)(() => textBoxT.TextBox.Text = js.ToString()));


                string ks = textBoxT.TextBox.Text;
                int row_ind = int.Parse(ks);
                int select = LCD.CurrentCell.RowIndex;
                row_ind--;

                LCD.Invoke((MethodInvoker)(() => LCD.CurrentCell = LCD.Rows[row_ind].Cells[1]));
                LCD.Rows[select].Selected = false;
                LCD.Rows[row_ind].Selected = true;

                string name = LCD.Rows[row_ind].Cells[0].Value.ToString();
                string First = LCD.Rows[row_ind].Cells[1].Value.ToString();

                FIO.Text = name + " " + First+":";
            }
            catch { }

        }

    }
}
