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

        Selenium run = new Selenium();

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            //TextBox1.Text = "";

        }

        private void InitializeMyControl()
        {
            // Put some text into the control first.  
            /*UsernameText.Text = "Enter username";
            PasswordText.Text = "Enter password";*/

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            run.User = UsernameText.Text;

            run.Pass = PasswordText.Text;

            run.Friend = FriendText.Text;

            run.Time = Convert.ToInt32( WaitTimeText.Text );

            run.FollowOrFollowing = false;//FollowersOrFollowingCheckBox.Checked;

            run.RunScript();

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FollowOrFollowingLabel_Click(object sender, EventArgs e)
        {

        }

        private void WaitTime_Click(object sender, EventArgs e)
        {

        }
    }

}
