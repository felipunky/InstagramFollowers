using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramFollowers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            UsernameText.Text = "";

        }

        private void InitializeMyControl()
        {
            // Put some text into the control first.  
            UsernameText.Text = "Enter username";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Selenium run = new Selenium();
            run.RunScript();
        }
    }
}
