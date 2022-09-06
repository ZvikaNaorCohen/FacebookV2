using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookEngine;

namespace BasicFacebookFeatures
{
    internal partial class FormMain : Form
    {
        private const string k_NoFriendsError = "No Friends Error";
        private const string k_NoFriendsText = "No friends were found.";
        private const string k_NoPostsText = "No Posts to retrieve :(";
        private const string k_AlbumsTitle = "Albums";
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

            labelFullName.BackColor = Color.Empty;
            makeProfilePictureCircle();
            updateFriendsDummyList();
            updateNewsFeed();
            userDataBindingSource.DataSource = m_UserData;
            userInformationBindingSource.DataSource = m_UserData.UserInformation;
        }

        private void makeProfilePictureCircle()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, pictureBoxProfile.Width, pictureBoxProfile.Height);
            Region rg = new Region(gp);
            pictureBoxProfile.Region = rg;
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
                tableLayoutPanelFriends.Controls.Add(friendItem, 0, ++friendCounter);
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
            Dictionary<PostsDummy, DateTime> postsDictionary = new Dictionary<PostsDummy, DateTime>();
            foreach(FriendsDummy friend in m_UserData.UserDummyFriendsList)
            {
                if(!friend.Muted)
                {
                    for(int i = 0; i < friend.AllUserDummyPosts.Count && i < k_MaxPostCount; i++)
                    {
                        postsDictionary.Add(friend.AllUserDummyPosts[i], friend.AllUserDummyPosts[i].DatePosted);
                    }
                }
            }

            IOrderedEnumerable<KeyValuePair<PostsDummy, DateTime>> sortedPostsDictionary = from entry in postsDictionary orderby entry.Value descending select entry;

            foreach (KeyValuePair<PostsDummy, DateTime> entry in sortedPostsDictionary)
            {
                // Old code:
                StringBuilder stringToAdd = new StringBuilder();

                // New code with DP [Write DP Name]:
                stringToAdd.Append(entry.Key.Author.Name);
                stringToAdd.Append(": ");
                stringToAdd.Append(entry.Key.Message);
                stringToAdd.Append(". Date: ");
                stringToAdd.Append(entry.Value);
                listBoxNewsFeed.Items.Add(stringToAdd);
            }

            if(listBoxNewsFeed.Items.Count == 0)
            {
                MessageBox.Show(k_NoPostsText);
            }
        }

        private void buttonGetGroups_Clicked(object sender, EventArgs e)
        {
            FormGroups groupsForm = new FormGroups(m_LoginSession);

            groupsForm.ShowDialog();
        }

        private void buttonClosestBirthdays_Clicked(object sender, EventArgs e)
        {
            FormBirthdays closestBirthdaysForm = new FormBirthdays(m_LoginSession);

            closestBirthdaysForm.ShowDialog();
        }

        private void buttonGetPages_Clicked(object sender, EventArgs e)
        {
            FormLikedPages likedPagesForm = new FormLikedPages(m_LoginSession);

            likedPagesForm.ShowDialog();
        }

        private void buttonGetAlbums_Clicked(object sender, EventArgs e)
        {
            FormAlbums albumsForm = new FormAlbums(m_UserData);

            albumsForm.Text = k_AlbumsTitle;
            albumsForm.AutoSize = true;
            albumsForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            albumsForm.ShowDialog();
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
