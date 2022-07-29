using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormAppSettings : Form
    {
        private const string k_AppId = "1225204811548586";
        public FormAppSettings()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            FacebookWrapper.LoginResult loginResult = FacebookService.Login(k_AppId,
                // requested permissions:
                "email", "public_profile");

            if(loginResult.LoggedInUser != null)
            {
                buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
                FormMain test = new FormMain();
                test.ShowDialog();
            }

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            this.buttonLogin.Text = "Login";
        }
    }
}
