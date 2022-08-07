using System;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    internal class FormLogin : Form
    {
        private const int k_FacebookCollectionLimit = 100;
        private const string k_AppId = "1225204811548586";
        private const string k_AppName = "Facebook App";
        private const string k_RememberLoginText = "Continue as";
        private const string k_LoginErrorMessage = "Login failed. Please try again.";
        private readonly string[] r_RequestedPermissions =
            {
                "email", "public_profile", "user_photos", "user_friends", "user_posts", "user_likes",
                "pages_read_user_content", "pages_read_engagement", "pages_manage_metadata",
                "groups_access_member_info",
            };

        private Session m_CurrentSession;
        private Button buttonLogin;
        private Button buttonLogout;
        private CheckBox checkBoxSaveLogin;

        internal FormLogin()
        {
            InitializeComponent();
            Icon = Properties.Resources.Lock;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            FacebookService.s_CollectionLimit = k_FacebookCollectionLimit;
            m_CurrentSession = new Session();
            checkSavedLogin();
        }

        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.checkBoxSaveLogin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(107, 60);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(269, 65);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(107, 145);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(269, 65);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // checkBoxSaveLogin
            // 
            this.checkBoxSaveLogin.AutoSize = true;
            this.checkBoxSaveLogin.Enabled = false;
            this.checkBoxSaveLogin.Location = new System.Drawing.Point(176, 250);
            this.checkBoxSaveLogin.Name = "checkBoxSaveLogin";
            this.checkBoxSaveLogin.Size = new System.Drawing.Size(119, 20);
            this.checkBoxSaveLogin.TabIndex = 2;
            this.checkBoxSaveLogin.Text = "Remember Me";
            this.checkBoxSaveLogin.UseVisualStyleBackColor = true;
            this.checkBoxSaveLogin.CheckedChanged += new System.EventHandler(this.checkBoxSaveLogin_CheckedChanged);
            // 
            // FormLogin
            // 
            this.ClientSize = new System.Drawing.Size(482, 327);
            this.Controls.Add(this.checkBoxSaveLogin);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void login()
        {
            if(!m_CurrentSession.IsLoggedIn())
            {
                LoginResult loginResult = FacebookService.Login(k_AppId, r_RequestedPermissions);

                if(!string.IsNullOrEmpty(loginResult.AccessToken))
                {
                    m_CurrentSession.Initialize(loginResult);
                    checkLoginStatus();
                }
                else
                {
                    MessageBox.Show(k_LoginErrorMessage, "Login Failed");
                }
            }
            else
            {
                FormMain formMain = new FormMain(m_CurrentSession);
                formMain.Text = k_AppName;
                Hide();
                formMain.ShowDialog();
                checkBoxSaveLogin.Checked = formMain.RememberMe;
                Show();
            }
        }

        private void checkSavedLogin()
        {
            if (Session.IsSessionSaved())
            {
                m_CurrentSession.LoadFromFile();
                checkBoxSaveLogin.Checked = true;
                checkLoginStatus();
            }
        }

        private void checkLoginStatus()
        {
            if (m_CurrentSession.IsLoggedIn())
            {
                buttonLogin.Text = $@"{k_RememberLoginText} {m_CurrentSession.UserName}";
                buttonLogout.Enabled = true;
                checkBoxSaveLogin.Enabled = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = @"Login";
            checkBoxSaveLogin.Checked = false;
            buttonLogout.Enabled = false;
            checkBoxSaveLogin.Enabled = false;
            m_CurrentSession.Terminate(false);
        }

        private void checkBoxSaveLogin_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSaveLogin.Checked)
            {
                m_CurrentSession.SaveToFile();
            }
            else
            {
                m_CurrentSession.DeleteSavedLogin();
            }
        }
    }
}
