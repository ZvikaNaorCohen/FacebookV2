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
        private LoginResult m_LoginResult;
        private AppSettings m_AppSettings;

        public FormAppSettings()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_AppSettings = AppSettings.LoadFromFile();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            m_LoginResult = FacebookService.Login(k_AppId, "email", "public_profile", "user_photos", "user_friends", "user_posts", "user_likes");
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                User loggedInUser = m_LoginResult.LoggedInUser;
                FormMain test = new FormMain(loggedInUser, m_LoginResult);
                test.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.", "Login Failed");
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (m_LoginResult != null && !string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_AppSettings.RememberUser = this.checkBoxKeepLoggedIn.Checked;
                m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                m_AppSettings.SaveToFile();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
        }
    }
}
