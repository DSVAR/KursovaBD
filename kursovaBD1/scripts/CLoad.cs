using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;


namespace kursovaBD.scripts
{
   

    class CLoad
    {
        static public DataGridView LCD = new DataGridView();
        static public ToolStripLabel label1 = new ToolStripLabel();
        static public ToolStripTextBox tex = new ToolStripTextBox();

        static public TextBox Name, FirstN, LastN, number;

        static public int js;

     static public void load()
        {
            string sql1 = "SELECT * FROM Clients";
            using (SqlConnection connection1 = new SqlConnection(Form1.connect))
            {
                connection1.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter(sql1, connection1);

                DataTable dt = new DataTable();
                sqlData.Fill(dt);

                LCD.Invoke((MethodInvoker)(() => LCD.DataSource = dt));
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

                string nm = LCD.Rows[row_ind].Cells[1].Value.ToString();
                string fn = LCD.Rows[row_ind].Cells[2].Value.ToString();
                string ln = LCD.Rows[row_ind].Cells[3].Value.ToString();
                string N = LCD.Rows[row_ind].Cells[4].Value.ToString();

                Name.Invoke((MethodInvoker)(() => Name.Text = nm));
                FirstN.Invoke((MethodInvoker)(() => FirstN.Text = fn));
                LastN.Invoke((MethodInvoker)(() => LastN.Text = ln));
                number.Invoke((MethodInvoker)(() => number.Text = N));
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
            LCD.Invoke((MethodInvoker)(() => LCD.CurrentCell = LCD.Rows[row_ind].Cells[1]));
            LCD.Rows[select].Selected = false;
            LCD.Rows[row_ind].Selected = true;

            string nm = LCD.Rows[row_ind].Cells[1].Value.ToString();
            string fn = LCD.Rows[row_ind].Cells[2].Value.ToString();
            string ln = LCD.Rows[row_ind].Cells[3].Value.ToString();
            string N = LCD.Rows[row_ind].Cells[4].Value.ToString();

            Name.Invoke((MethodInvoker)(() => Name.Text = nm));
            FirstN.Invoke((MethodInvoker)(() => FirstN.Text = fn));
            LastN.Invoke((MethodInvoker)(() => LastN.Text = ln));
            number.Invoke((MethodInvoker)(() => number.Text = N));
        }


        static public void ChangePlus()
        {
             js = LCD.CurrentCell.RowIndex;
            js+=2;
            tex.TextBox.Invoke((MethodInvoker)(() => tex.TextBox.Text = js.ToString()));


            string ks = tex.TextBox.Text;
            int row_ind = int.Parse(ks);
            int select = LCD.CurrentCell.RowIndex;
         row_ind--;
           
            LCD.Invoke((MethodInvoker)(() => LCD.CurrentCell = LCD.Rows[row_ind].Cells[1]));
            LCD.Rows[select].Selected = false;
            LCD.Rows[row_ind].Selected = true;

            string nm = LCD.Rows[row_ind].Cells[1].Value.ToString();
            string fn = LCD.Rows[row_ind].Cells[2].Value.ToString();
            string ln = LCD.Rows[row_ind].Cells[3].Value.ToString();
            string N = LCD.Rows[row_ind].Cells[4].Value.ToString();

            Name.Invoke((MethodInvoker)(() => Name.Text = nm));
            FirstN.Invoke((MethodInvoker)(() => FirstN.Text = fn));
            LastN.Invoke((MethodInvoker)(() => LastN.Text = ln));
            number.Invoke((MethodInvoker)(() => number.Text = N));

        }
    }
}
