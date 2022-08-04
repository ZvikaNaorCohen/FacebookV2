using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const int k_MaxPostCount = 4;
        private Session m_LoginSession;
        private UserData m_UserData;

        public FormMain(Session i_LoginSession)
        {
            m_LoginSession = i_LoginSession;
            m_UserData = m_LoginSession.UserData;
            InitializeComponent();
            if(Session.IsSessionSaved())
            {
                checkBoxKeepLoggedIn.Checked = true;
            }

            fetchUserInfo();
        }

        public bool RememberMe
        {
            get
            {
                return checkBoxKeepLoggedIn.Checked;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if(!checkBoxKeepLoggedIn.Checked)
            {
                m_LoginSession.Terminate(checkBoxKeepLoggedIn.Checked);
            }
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.Image = m_UserData.ProfilePicture;
            labelFullName.Text = m_LoginSession.UserName;
            labelFullName.BackColor = Color.Empty;
            makeProfilePictureCircle();
            updateFriendsDummyList();
            updateNewsFeed();
            updateUserInfo();
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
            listBoxFriends.Items.Clear();
            foreach (FriendsDummy friend in m_UserData.UserDummyFriendsList)
            {
                listBoxFriends.Items.Add(friend.Name);
            }

            if (m_UserData.UserDummyFriendsList.Count == 0)
            {
                MessageBox.Show("No friends were found. ", "No Friends Error");
            }
        }

        private void updateNewsFeed()
        {
            listBoxNewsFeed.Items.Clear();
            Dictionary<PostsDummy, DateTime> postsDictionary = new Dictionary<PostsDummy, DateTime>();
            foreach(FriendsDummy friend in m_UserData.UserDummyFriendsList)
            {
                for(int i = 0; i < friend.AllUserDummyPosts.Count && i < k_MaxPostCount; i++)
                {
                    postsDictionary.Add(friend.AllUserDummyPosts[i], friend.AllUserDummyPosts[i].DatePosted);
                }
            }

            // Sort by dates
            var sortedPostsDictionary = from entry in postsDictionary orderby entry.Value descending select entry;

            foreach (KeyValuePair<PostsDummy, DateTime> entry in sortedPostsDictionary)
            {
                StringBuilder stringToAdd = new StringBuilder();
                stringToAdd.Append(entry.Key.Author.Name);
                stringToAdd.Append(": ");
                stringToAdd.Append(entry.Key.Message);
                stringToAdd.Append(". Date: ");
                stringToAdd.Append(entry.Value);
                listBoxNewsFeed.Items.Add(stringToAdd);
            }

            if(listBoxNewsFeed.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void updateUserInfo()
        {
            listBoxUserInfo.Items.Clear();
            listBoxUserInfo.Items.Add("Gender: " + m_UserData.UserInformation.Gender);
            listBoxUserInfo.Items.Add("Birth Date: " + m_UserData.UserInformation.Birthday);
            listBoxUserInfo.Items.Add("From: " + m_UserData.UserInformation.Hometown);
            listBoxUserInfo.Items.Add("Relationship Status: " + m_UserData.UserInformation.RelationshipStatus);
            listBoxUserInfo.Items.Add("Email: " + m_UserData.UserInformation.Email);
            listBoxUserInfo.Items.Add("Interested in: " + m_UserData.UserInformation.InterestedIn);
        }

        private void buttonGetGroups_Clicked(object sender, EventArgs e)
        {
            FormMoreInfo groupsForm = new FormMoreInfo(m_LoginSession);

            groupsForm.FetchInfo(typeof(Group));
            groupsForm.ShowDialog();
        }

        private void buttonClosestBirthdays_Clicked(object sender, EventArgs e)
        {
            FormMoreInfo closestBirthdaysForm = new FormMoreInfo(m_LoginSession);

            closestBirthdaysForm.FetchInfo(typeof(FriendsDummy));
            closestBirthdaysForm.ShowDialog();
        }

        private void buttonGetPages_Clicked(object sender, EventArgs e)
        {
            FormMoreInfo groupsForm = new FormMoreInfo(m_LoginSession);

            groupsForm.FetchInfo(typeof(Page));
            groupsForm.ShowDialog();
        }

        private void buttonGetEvents_Clicked(object sender, EventArgs e)
        {
            FormMoreInfo groupsForm = new FormMoreInfo(m_LoginSession);

            groupsForm.FetchInfo(typeof(Event));
            groupsForm.ShowDialog();
        }

        private void buttonGetAlbums_Clicked(object sender, EventArgs e)
        {
            FormMoreInfo groupsForm = new FormMoreInfo(m_LoginSession);

            groupsForm.FetchInfo(typeof(Album));
            groupsForm.ShowDialog();
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
