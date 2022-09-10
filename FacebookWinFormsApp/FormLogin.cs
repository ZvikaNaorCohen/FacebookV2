using System;
using System.Threading;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    internal class FormLogin : Form
    {
        private const int k_FacebookCollectionLimit = 100;
        private const string k_AppId = "1225204811548586";
        private const string k_LoginText = "Login";
        private const string k_RememberLoginText = "Continue as";
        private const string k_LoginError = "Login failed";
        private const string k_LoginErrorMessage = "Login failed. Please try again.";
        private const string k_ConnectText = "Connecting to Facebook...";
        private readonly string[] r_RequestedPermissions =
            {
                "email", "public_profile", "user_photos", "user_friends", "user_posts", "user_likes",
                "pages_read_user_content", "pages_read_engagement", "pages_manage_metadata",
                "groups_access_member_info",
            };

        private Session m_CurrentSession;
        private Button m_ButtonLogin;
        private Button m_ButtonLogout;
        private CheckBox m_CheckBoxSaveLogin;

        internal FormLogin()
        {
            InitializeComponent();
            Icon = Properties.Resources.Lock;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            FacebookService.s_CollectionLimit = k_FacebookCollectionLimit;
            m_CurrentSession = Session.Instance;
            checkSavedLogin();
        }

        private void InitializeComponent()
        {
            this.m_ButtonLogin = new System.Windows.Forms.Button();
            this.m_ButtonLogout = new System.Windows.Forms.Button();
            this.m_CheckBoxSaveLogin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.m_ButtonLogin.Location = new System.Drawing.Point(107, 60);
            this.m_ButtonLogin.Name = "buttonLogin";
            this.m_ButtonLogin.Size = new System.Drawing.Size(269, 65);
            this.m_ButtonLogin.TabIndex = 0;
            this.m_ButtonLogin.Text = "Login";
            this.m_ButtonLogin.UseVisualStyleBackColor = true;
            this.m_ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.m_ButtonLogout.Enabled = false;
            this.m_ButtonLogout.Location = new System.Drawing.Point(107, 145);
            this.m_ButtonLogout.Name = "buttonLogout";
            this.m_ButtonLogout.Size = new System.Drawing.Size(269, 65);
            this.m_ButtonLogout.TabIndex = 1;
            this.m_ButtonLogout.Text = "Logout";
            this.m_ButtonLogout.UseVisualStyleBackColor = true;
            this.m_ButtonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // checkBoxSaveLogin
            // 
            this.m_CheckBoxSaveLogin.AutoSize = true;
            this.m_CheckBoxSaveLogin.Enabled = false;
            this.m_CheckBoxSaveLogin.Location = new System.Drawing.Point(176, 250);
            this.m_CheckBoxSaveLogin.Name = "checkBoxSaveLogin";
            this.m_CheckBoxSaveLogin.Size = new System.Drawing.Size(119, 20);
            this.m_CheckBoxSaveLogin.TabIndex = 2;
            this.m_CheckBoxSaveLogin.Text = "Remember Me";
            this.m_CheckBoxSaveLogin.UseVisualStyleBackColor = true;
            this.m_CheckBoxSaveLogin.CheckedChanged += new System.EventHandler(this.checkBoxSaveLogin_CheckedChanged);
            // 
            // FormLogin
            // 
            this.ClientSize = new System.Drawing.Size(482, 327);
            this.Controls.Add(this.m_CheckBoxSaveLogin);
            this.Controls.Add(this.m_ButtonLogout);
            this.Controls.Add(this.m_ButtonLogin);
            this.Name = "FormLogin";
            this.Tag = "Login";
            this.Text = "Login to facebook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void login()
        {
            if(!m_CurrentSession.IsLoggedIn())
            {
                m_ButtonLogin.Enabled = false;
                m_ButtonLogin.Text = k_ConnectText;
                new Thread(normalLogin).Start();
            }
            else
            {
                continueToFacebook();
            }
        }

        private void normalLogin()
        {
            LoginResult loginResult = FacebookService.Login(k_AppId, r_RequestedPermissions);

            if(!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                m_CurrentSession.Initialize(loginResult);
                m_ButtonLogin.Invoke(new Action(checkLoginStatus));
            }
            else
            {
                MessageBox.Show(k_LoginErrorMessage, k_LoginError);
                m_ButtonLogin.Invoke(new Action(resetLoginButton));
            }
        }

        private void continueToFacebook()
        {
            Form formMain = FacebookFormFactory.CreateNewFacebookForm("Main");
            Hide();
            formMain.ShowDialog();
            m_CheckBoxSaveLogin.Checked = ((FormMain)formMain).RememberMe;
            Show();
        }

        private void resetLoginButton()
        {
            m_ButtonLogin.Enabled = true;
            m_ButtonLogin.Text = k_LoginText;
        }

        private void checkSavedLogin()
        {
            if (Session.IsSessionSaved())
            {
                m_ButtonLogin.Enabled = false;
                m_ButtonLogin.Text = k_ConnectText;
                new Thread(savedLoginConnect).Start();
            }
        }

        private void savedLoginConnect()
        {
            m_CurrentSession.LoadFromFile();
            m_CheckBoxSaveLogin.Invoke(new Action(() => m_CheckBoxSaveLogin.Checked = true));
            m_ButtonLogin.Invoke(new Action(checkLoginStatus));
        }

        private void checkLoginStatus()
        {
            if (m_CurrentSession.IsLoggedIn())
            {
                m_ButtonLogin.Text = $@"{k_RememberLoginText} {m_CurrentSession.UserName}";
                m_ButtonLogout.Enabled = true;
                m_CheckBoxSaveLogin.Enabled = true;
                m_ButtonLogin.Enabled = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_ButtonLogin.Text = k_LoginText;
            m_CheckBoxSaveLogin.Checked = false;
            m_ButtonLogout.Enabled = false;
            m_CheckBoxSaveLogin.Enabled = false;
            FacebookService.LogoutWithUI();
            m_CurrentSession.Terminate(false);
        }

        private void checkBoxSaveLogin_CheckedChanged(object sender, EventArgs e)
        {
            if(m_CheckBoxSaveLogin.Checked)
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
