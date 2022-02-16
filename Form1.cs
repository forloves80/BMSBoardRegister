using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMSBoardRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox_hide.Checked = true;
        }

        private void checkBox_hide_CheckedChanged(object sender, EventArgs e)
        {
            textBox_pw.PasswordChar = (checkBox_hide.Checked) ? '*' : '\0';
        }
    }
}
