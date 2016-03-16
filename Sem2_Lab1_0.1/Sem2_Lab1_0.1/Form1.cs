using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2_Lab1_0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmAboutProg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Artem Zhulai\nand Ilya Myhalyov.\n(c) 2016", "О программе");                           //Инфо о программе
        }

        private void rtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsmChangeDateFormat_Click(object sender, EventArgs e)
        {
            DateTime date;
            string text = rtxtbox.Text;

            if (String.IsNullOrEmpty(text) == false)                                                                        //Проверка на наличие текста
            {                
                for (int i = 0; i < (text.Length) - 9; i++)                                                                 //Цикл, который выполняется, пока в тексте возможно наличие даты
                {
                    try
                    {
                        date = DateTime.Parse(text.Substring(i, 10));                                                       //Преобразование даты, как строки в объект класса DateTime
                        if (text[i + 2] == '.' && text[i + 5] == '.')                                                       //Проверка "на дату"
                        {
                            rtxtbox.Text = rtxtbox.Text.Replace(text.Substring(i, 10), date.ToString("yyyy-MM-dd"));        //Вывод преобразованной даты

                        }
                    }
                    catch                                                                                                   //Обработка исключений
                    {
                    }
                }
            }
        }

        private void tsmPasteDoc_Click(object sender, EventArgs e)
        {

        }
    }
}
