using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "1225204811548586";
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private Session m_AppSettings;
        private UserData m_UserData;

        public FormMain(User i_LoggedInUser, LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
            m_LoggedInUser = i_LoggedInUser;
            m_UserData = new UserData(m_LoggedInUser);
            InitializeComponent();
           //  m_AppSettings = AppSettings.LoadFromFile();
            fetchUserInfo();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FacebookService.LogoutWithUI();
            // buttonLogin.Text = "Login";
        }

        private void fetchUserInfo()
        {
            // UserData userData = new UserData(m_LoggedInUser);
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            labelFullName.Text = m_LoggedInUser.Name;
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

        //private void updateFriendsList()
        //{
        //    // Can't get friends list from facebook. Need to random some users.

        //    // listBoxFriends.Items.Clear();
        //    // foreach (User friend in m_LoggedInUser.Friends)
        //    // {
        //    //    listBoxFriends.Items.Add(friend);
        //    // }

        //    // if (m_LoggedInUser.Friends.Count == 0)
        //    // {
        //    //    MessageBox.Show("No friends were found. ", "No Friends Error");
        //    // }
        //}

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
                for(int i = 0; i < friend.AllUserDummyPosts.Count && i < 4; i++)
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
            listBoxUserInfo.Items.Add("Gender: " + m_LoggedInUser.Gender);
            listBoxUserInfo.Items.Add("Birth Date: " + m_LoggedInUser.Birthday);
            listBoxUserInfo.Items.Add("From: " + m_LoggedInUser.Hometown);
            listBoxUserInfo.Items.Add("Relationship Status: " + m_LoggedInUser.RelationshipStatus);
            listBoxUserInfo.Items.Add("Email: " + m_LoggedInUser.Email);
            listBoxUserInfo.Items.Add("Interested in: " + m_LoggedInUser.InterestedIn);
        }

        private void buttonGetGroups_Clicked(object sender, EventArgs e)
        {
            FormMoreInfo groupsForm = new FormMoreInfo(m_LoggedInUser);

            groupsForm.FetchInfo(typeof(Group));
            groupsForm.ShowDialog();
        }

        private void buttonClosestBirthdays_Clicked(object sender, EventArgs e)
        {
            FormMoreInfo closestBirthdaysForm = new FormMoreInfo(m_LoggedInUser);

            closestBirthdaysForm.FetchInfo(typeof(FriendsDummy));
            closestBirthdaysForm.ShowDialog();
        }

        private void buttonGetPages_Clicked(object sender, EventArgs e)
        {
            FormMoreInfo groupsForm = new FormMoreInfo(m_LoggedInUser);

            groupsForm.FetchInfo(typeof(Page));
            groupsForm.ShowDialog();
        }

        private void buttonGetEvents_Clicked(object sender, EventArgs e)
        {
            FormMoreInfo groupsForm = new FormMoreInfo(m_LoggedInUser);

            groupsForm.FetchInfo(typeof(Event));
            groupsForm.ShowDialog();
        }

        private void buttonGetAlbums_Clicked(object sender, EventArgs e)
        {
            FormMoreInfo groupsForm = new FormMoreInfo(m_LoggedInUser);

            groupsForm.FetchInfo(typeof(Album));
            groupsForm.ShowDialog();
        }
    }
}
