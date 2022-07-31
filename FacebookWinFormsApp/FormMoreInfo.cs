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
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMoreInfo : Form
    {
        public User m_LoggedInUser;

        public FormMoreInfo(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        public void FetchInfo(Type i_Type)
        {
            UserData userData = new UserData(m_LoggedInUser);
            resetAllListBoxes();
            listBoxName.DisplayMember = "Name";

            switch(i_Type.Name)
            {
                case "Group":
                    {
                        foreach(Group group in m_LoggedInUser.Groups)
                        {
                            listBoxName.Items.Add(group);
                        }

                        break;
                    }
                case "Album":
                    {
                        foreach(Album album in userData.GetSortedAlbumsList(eSortBy.Count))
                        {
                            listBoxName.Items.Add(album.Name);
                        }


                        break;
                    }
                case "Page":
                    {
                        //foreach(Page page in userData.GetSortedPagesList(eSortBy.Count))
                        //{
                        //    listBoxName.Items.Add(page.Name);
                        //    listBoxLastPost.Items.Add(page.WallPosts[0].Name);
                        //    listBoxLastPostAuthor.Items.Add(page.WallPosts[0].Name);
                        //    listBoxLastPostDate.Items.Add(page.WallPosts[0].UpdateTime.GetValueOrDefault());
                        //}

                        break;
                    }
                case "Event":
                    {
                        foreach(Event userEvent in userData.GetSortedEventsList(eSortBy.Count))
                        {
                            listBoxName.Items.Add(userEvent.Name);
                            listBoxLastPost.Items.Add(userEvent.WallPosts[0].Description);
                            listBoxLastPostAuthor.Items.Add(userEvent.WallPosts[0].Name);
                            listBoxLastPostDate.Items.Add(userEvent.UpdateTime);
                        }

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void resetAllListBoxes()
        {
            listBoxLastPost.Items.Clear();
            listBoxName.Items.Clear();
            listBoxLastPostAuthor.Items.Clear();
            listBoxLastPostDate.Items.Clear();
        }
    }
}
