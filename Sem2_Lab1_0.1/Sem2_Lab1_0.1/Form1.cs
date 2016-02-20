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
            if (rtxtbox.Text != "")
            {
                string text = rtxtbox.Text;
                int data = 0, moon = 0, year = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    try
                    {
                        data = Convert.ToInt32(text.Substring(i, 2));
                        moon = Convert.ToInt32(text.Substring(i + 3, 2));
                        year = Convert.ToInt32(text.Substring(i + 6, 4));
                    }
                    catch (Exception)
                    {continue;}
                    if (text[i + 2] == '.' && text[i + 5] == '.' &&
                        data <= 31 && data > 0 && moon <= 12 && moon > 0)
                    {
                        if (data < 10 && moon < 10)
                        rtxtbox.Text = 
                                rtxtbox.Text.Replace(("0" + data + "." + "0" + moon + "." + year),
                            (year + "-" + "0" + moon + "-" + "0" + data));
                        else if (data < 10)
                            rtxtbox.Text =
                                rtxtbox.Text.Replace(("0" + data + "." + moon + "." + year),
                            (year + "-" + moon + "-" + "0" + data));
                        else if (moon < 10)
                            rtxtbox.Text =
                                rtxtbox.Text.Replace((data + "." + "0" + moon + "." + year),
                            (year + "-" + "0" + moon + "-" + data));
                        else rtxtbox.Text =
                               rtxtbox.Text.Replace((data + "." + moon + "." + year),
                           (year + "-" + moon + "-" + data));
                    }
                }
            }
        }
    }
}
