using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kursovaBD1.scripts
{
    class change_help
    {
        static public Label text = new Label();
        static public PictureBox Pbox,Pbox2 = new PictureBox();
        static public RichTextBox text2 = new RichTextBox();
        static public LinkLabel label1, label2 = new LinkLabel();
       static public void develop() 
        {
            text.Visible = true;
            text2.Visible = true;
            Pbox.Visible = false;
            Pbox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            text.Text = "Добавление данных";
            text2.Text = "Добавдение клиентов происходит в колонке N1. Добавление зданий для продажи происходит в колонке N2. В колонке автоматически высвечиваются клиенты и здания. надо лишь заполнить и обновить конфигурацию ";
        }

        static public void search()
        {
            Pbox2.Visible = false;
            Pbox.Visible = true;
            
        //    string path = Path.Combine(Environment.CurrentDirectory);
         //   MessageBox.Show(path);
            text.Text = "Поиск";
            text2.Text = "Поиск осуществляется по фамилии клиента. Надо написать фамилию клиента или здание в строку" +
                "поиска и после нажать на иконку с лупой. Что бы вывести всех клиентов обратно, стираете все из строки поиска " +
                " и так же жмете на лупу";
      

        }

        static public void sort()
        {
            Pbox.Visible = false;
            Pbox2.Visible = true;
         
            //    string path = Path.Combine(Environment.CurrentDirectory);
            //   MessageBox.Show(path);
            text.Text = "Сортировка";
            text2.Text = "Сортировка работает по Имени, фамилии и тд. надо лишь нажать на поле которое вы хотите сортировать";

        }
        static public void developed()
        {
            text.Visible = false;
            text2.Visible = true;
            Pbox.Visible = false;
            Pbox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            text2.Height = 300;
            text2.Text = "Работу выполнит студент 4 курса Нурмехаметов Данил";
        }
    }
}
