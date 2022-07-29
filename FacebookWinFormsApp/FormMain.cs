﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "1225204811548586";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    k_AppId,
                    /// requested permissions:
					"email",
                    "public_profile"
                    /// add any relevant permissions
                    );

            buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
        }
	}
}
