using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormAppSettings : Form
    {
        private const string k_AppId = "1225204811548586";
        private LoginResult m_LoginResult;
        private Session m_CurrentSession;

        private string ZVIKA_ACCESS_TOKEN_DELETE =
            "EAARaUTmRx6oBAElF3HZCfZB9OxKe8yoKyCCCStF92vOLQBPEvKj4bByDcZCSNDXsOryNrZATsciWurDZB0FipEEaZAKpXSYQZBfAjJ3c2eXT43J8Hz5i2tPYsHH3Vs0v181oC3lbjeA3jXOAzmr8thk7weGYhB4FWRjw8ovZBCNMpqiPJN4DL81dpcomGjNrZAToZD";


        public FormAppSettings()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            // m_CurrentSession = Session.LoadFromFile();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            m_LoginResult = FacebookService.Login(k_AppId, "email", "public_profile", "user_photos", "user_friends", "user_posts", "user_likes", "pages_read_user_content", "pages_read_engagement", "pages_manage_metadata", "groups_access_member_info");
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            // m_LoginResult = FacebookService.Connect(k_AppId, ZVIKA_ACCESS_TOKEN_DELETE);
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
                //m_CurrentSession.RememberMe = this.checkBoxKeepLoggedIn.Checked;
                //m_CurrentSession.AccessToken = m_LoginResult.AccessToken;
                //m_CurrentSession.SaveToFile();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
        }
    }
}
