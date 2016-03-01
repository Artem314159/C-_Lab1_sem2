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
            MessageBox.Show("Made by Artem Zhulai\nand Ilya Myhalyov.\n(c) 2016", "О программе");
        }

        private void rtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsmChangeDateFormat_Click(object sender, EventArgs e)
        {
            DateTime date;
            string text = rtxtbox.Text;

            if (String.IsNullOrEmpty(text) == false)
            {                
                for (int i = 0; i < (text.Length) - 9; i++)
                {
                    try
                    {
                        date = DateTime.Parse(text.Substring(i, 10));
                        if (text[i + 2] == '.' && text[i + 5] == '.')
                        {
                            rtxtbox.Text = rtxtbox.Text.Replace(text.Substring(i, 10), date.ToString("yyyy-MM-dd"));

                        }
                    }
                    catch
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
