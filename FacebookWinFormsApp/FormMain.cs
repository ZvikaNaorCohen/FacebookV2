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

        public FormMain(User i_LoggedInUser, LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
            m_LoggedInUser = i_LoggedInUser;
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
            UserData userData = new UserData(m_LoggedInUser);
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            labelFullName.Text = m_LoggedInUser.Name;
            labelFullName.BackColor = Color.Empty;

            makeProfilePictureCircle();
            // updateFriendsList();
            updateNewsFeed();
        }

        private void makeProfilePictureCircle()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxProfile.Width, pictureBoxProfile.Height);
            Region rg = new Region(gp);
            pictureBoxProfile.Region = rg;
        }

        private void updateFriendsList()
        {
            // Can't get friends list from facebook. Need to random some users.

            // listBoxFriends.Items.Clear();
            // foreach (User friend in m_LoggedInUser.Friends)
            // {
            //    listBoxFriends.Items.Add(friend);
            // }

            // if (m_LoggedInUser.Friends.Count == 0)
            // {
            //    MessageBox.Show("No friends were found. ", "No Friends Error");
            // }
        }

        private void updateNewsFeed()
        {
            listBoxNewsFeed.Items.Clear();

            foreach(Post post in m_LoggedInUser.Posts)
            {
                if(post.Message != null)
                {
                    listBoxNewsFeed.Items.Add(post.Message);
                }
                else if(post.Caption != null)
                {
                    listBoxNewsFeed.Items.Add(post.Caption);
                }
                else
                {
                    listBoxNewsFeed.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if(listBoxNewsFeed.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonGetGroups_Clicked(object sender, EventArgs e)
        {
            FormMoreInfo groupsForm = new FormMoreInfo(m_LoggedInUser);

            groupsForm.FetchInfo(typeof(Group));
            groupsForm.ShowDialog();
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
