using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookEngine;

namespace BasicFacebookFeatures
{
    internal partial class FormMain : Form
    {
        private const string k_NoFriendsError = "No Friends Error";
        private const string k_NoFriendsText = "No friends were found.";
        private const string k_NoPostsText = "No Posts to retrieve :(";
        private const int k_FriendsWidth = 165;
        private const int k_FriendsHeight = 175;
        private const int k_MaxPostCount = 4;
        private Session m_LoginSession;
        private UserData m_UserData;

        internal FormMain()
        {
            InitializeComponent();
            HandleCreated += HandleCreated_FetchInfo;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Icon = Properties.Resources.Facebook;
        }

        internal bool RememberMe
        {
            get
            {
                return checkBoxKeepLoggedIn.Checked;
            }
        }

        private void fetchUserInfo()
        {
            m_LoginSession = Session.Instance;
            m_UserData = m_LoginSession.UserData;
            if (Session.IsSessionSaved())
            {
                checkBoxKeepLoggedIn.Checked = true;
            }

            makeProfilePictureCircle();
            updateFriendsDummyList();
            updateNewsFeed();
            userDataBindingSource.DataSource = m_UserData;
            userInformationBindingSource.DataSource = m_UserData.UserInformation;
        }

        private void makeProfilePictureCircle()
        {
            Region region;
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddEllipse(0, 0, pictureBoxProfile.Width, pictureBoxProfile.Height);
            region = new Region(graphicsPath);
            pictureBoxProfile.Region = region;
        }

        private void updateFriendsDummyList()
        {
            int friendCounter = 0;
            tableLayoutPanelFriends.Size = new Size(k_FriendsWidth, k_FriendsHeight);
            tableLayoutPanelFriends.AutoScroll = true;
            foreach (FriendsDummy friend in m_UserData.UserDummyFriendsList)
            {
                ButtonFriend friendItem = new ButtonFriend(friend);
                friendItem.Text = friend.Name;
                friendItem.Click += FriendItem_Click;
                tableLayoutPanelFriends.Controls.Add(friendItem, 0, friendCounter++);
            }

            if (m_UserData.UserDummyFriendsList.Count == 0)
            {
                MessageBox.Show(k_NoFriendsText, k_NoFriendsError);
            }
        }

        private void FriendItem_Click(object sender, EventArgs e)
        {
            if(sender is ButtonFriend clickedFriend)
            {
                clickedFriend.SwitchNewsState();
                updateNewsFeed();
            }
        }

        private void HandleCreated_FetchInfo(object sender, EventArgs e)
        {
            fetchUserInfo();
        }

        private void updateNewsFeed()
        {
            listBoxNewsFeed.Items.Clear();
            foreach(string post in m_UserData.GetPosts(k_MaxPostCount))
            {
                listBoxNewsFeed.Items.Add(post);
            }

            if (listBoxNewsFeed.Items.Count == 0)
            {
                MessageBox.Show(k_NoPostsText);
            }
        }

        private void buttonFacebookForm_Clicked(object sender, EventArgs e)
        {
            Form facebookForm = FacebookFormFactory.CreateNewFacebookForm((sender as Button)?.Tag as string);
            facebookForm.ShowDialog();
        }

        private void checkBoxKeepLoggedIn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKeepLoggedIn.Checked)
            {
               m_LoginSession.SaveToFile();
            }
            else
            {
                m_LoginSession.DeleteSavedLogin();
            }
        }
    }
}
