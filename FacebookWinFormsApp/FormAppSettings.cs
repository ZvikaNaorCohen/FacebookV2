using System;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormAppSettings : Form
    {
        private const string k_AppId = "1225204811548586";
        private const int k_FacebookCollectionLimit = 100;
        private Session m_CurrentSession;
        private LoginResult m_LoginResult;

        public FormAppSettings()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = k_FacebookCollectionLimit;
            checkSavedLogin();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
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

        private void checkSavedLogin()
        {
            if(Session.IsSessionSaved())
            {
                m_CurrentSession = Session.LoadFromFile();
            }
        }
    }
}
