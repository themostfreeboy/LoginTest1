using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginTest_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username=this.textBoxUsername.Text.ToString();
            string userpassword=this.textBoxUserpassword.Text.ToString();
            string str = "null";
            if (String.Compare(username, "jxl") == 0 && String.Compare(userpassword, "jxl") == 0)
            {
                str = "succeed";
            }
            else
            {
                str = "fail";
            }
            MessageBox.Show(str);
        }
    }
}
