namespace InstagramFollowers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.WaitTime = new System.Windows.Forms.Label();
            this.WaitTimeText = new System.Windows.Forms.TextBox();
            this.FriendLabel = new System.Windows.Forms.Label();
            this.FriendText = new System.Windows.Forms.TextBox();
            this.FollowersOrFollowingCheckBox = new System.Windows.Forms.CheckBox();
            this.FollowOrFollowingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(98, 14);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(609, 21);
            this.UsernameText.TabIndex = 0;
            this.UsernameText.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RunButton.Location = new System.Drawing.Point(648, 359);
            this.RunButton.Margin = new System.Windows.Forms.Padding(2);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(144, 83);
            this.RunButton.TabIndex = 5;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(98, 59);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(609, 21);
            this.PasswordText.TabIndex = 1;
            this.PasswordText.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(37, 17);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.Username_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(37, 62);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(55, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // WaitTime
            // 
            this.WaitTime.AutoSize = true;
            this.WaitTime.Location = new System.Drawing.Point(37, 154);
            this.WaitTime.Name = "WaitTime";
            this.WaitTime.Size = new System.Drawing.Size(108, 13);
            this.WaitTime.TabIndex = 6;
            this.WaitTime.Text = "Wait time in seconds";
            // 
            // WaitTimeText
            // 
            this.WaitTimeText.BackColor = System.Drawing.SystemColors.Window;
            this.WaitTimeText.Location = new System.Drawing.Point(146, 151);
            this.WaitTimeText.Name = "WaitTimeText";
            this.WaitTimeText.Size = new System.Drawing.Size(559, 21);
            this.WaitTimeText.TabIndex = 3;
            // 
            // FriendLabel
            // 
            this.FriendLabel.AutoSize = true;
            this.FriendLabel.Location = new System.Drawing.Point(37, 110);
            this.FriendLabel.Name = "FriendLabel";
            this.FriendLabel.Size = new System.Drawing.Size(38, 13);
            this.FriendLabel.TabIndex = 8;
            this.FriendLabel.Text = "Friend";
            // 
            // FriendText
            // 
            this.FriendText.Location = new System.Drawing.Point(98, 107);
            this.FriendText.Name = "FriendText";
            this.FriendText.Size = new System.Drawing.Size(609, 21);
            this.FriendText.TabIndex = 2;
            this.FriendText.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // FollowersOrFollowingCheckBox
            // 
            this.FollowersOrFollowingCheckBox.AutoSize = true;
            this.FollowersOrFollowingCheckBox.Location = new System.Drawing.Point(407, 198);
            this.FollowersOrFollowingCheckBox.Name = "FollowersOrFollowingCheckBox";
            this.FollowersOrFollowingCheckBox.Size = new System.Drawing.Size(15, 14);
            this.FollowersOrFollowingCheckBox.TabIndex = 4;
            this.FollowersOrFollowingCheckBox.UseVisualStyleBackColor = true;
            this.FollowersOrFollowingCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // FollowOrFollowingLabel
            // 
            this.FollowOrFollowingLabel.AutoSize = true;
            this.FollowOrFollowingLabel.Location = new System.Drawing.Point(37, 198);
            this.FollowOrFollowingLabel.Name = "FollowOrFollowingLabel";
            this.FollowOrFollowingLabel.Size = new System.Drawing.Size(364, 13);
            this.FollowOrFollowingLabel.TabIndex = 9;
            this.FollowOrFollowingLabel.Text = "Followers or Following? Checked for followers, Unchecked for following";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FollowersOrFollowingCheckBox);
            this.Controls.Add(this.FollowOrFollowingLabel);
            this.Controls.Add(this.FriendLabel);
            this.Controls.Add(this.FriendText);
            this.Controls.Add(this.WaitTime);
            this.Controls.Add(this.WaitTimeText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.UsernameText);
            this.Font = new System.Drawing.Font("Interstate Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "InstagramFollowers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label WaitTime;
        private System.Windows.Forms.TextBox WaitTimeText;
        private System.Windows.Forms.Label FriendLabel;
        private System.Windows.Forms.TextBox FriendText;
        private System.Windows.Forms.CheckBox FollowersOrFollowingCheckBox;
        private System.Windows.Forms.Label FollowOrFollowingLabel;
    }
}

