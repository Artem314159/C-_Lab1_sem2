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
            
        }
    }
}
