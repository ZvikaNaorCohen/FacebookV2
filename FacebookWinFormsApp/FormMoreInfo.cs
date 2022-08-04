using System;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMoreInfo : Form
    {
        private Session m_LoginSession;

        public FormMoreInfo(Session i_LoginSession)
        {
            m_LoginSession = i_LoginSession;
            InitializeComponent();
        }

        public void FetchInfo(Type i_Type)
        {
            UserData userData = m_LoginSession.UserData;
            resetAllListBoxes();
            listBoxName.DisplayMember = "Name";

            switch(i_Type.Name)
            {
                case "Group":
                    {
                        foreach(Group group in userData.GetSortedGroupsList(eSortBy.Name))
                        {
                            listBoxName.Items.Add(group);
                            if(!string.IsNullOrEmpty(group.Description))
                            {
                                listBoxLastPost.Items.Add(group.Description);
                            }
                            else
                            {
                                listBoxLastPost.Items.Add("  ");
                            }

                            if(group.Owner != null)
                            {
                                listBoxLastPostAuthor.Items.Add(group.Owner.Name);
                            }
                            else
                            {
                                listBoxLastPostAuthor.Items.Add("  ");
                            }
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

                        foreach(Page page in userData.GetSortedPagesList(eSortBy.Name))
                        {
                            listBoxName.Items.Add(page);
                            // listBoxLastPost.Items.Add(page.Description);
                        }

                        break;
                    }
                case "Event":
                    {
                        foreach(Event userEvent in userData.GetSortedEventsList(eSortBy.Count))
                        {
                            listBoxName.Items.Add(userEvent.Name);
                            //listBoxLastPost.Items.Add(userEvent.WallPosts[0].Description);
                            //listBoxLastPostAuthor.Items.Add(userEvent.WallPosts[0].Name);
                            //listBoxLastPostDate.Items.Add(userEvent.UpdateTime);
                        }

                        break;
                    }
                case "FriendsDummy":
                    {
                        foreach (FriendsDummy friend in userData.UserDummyFriendsList)
                        {
                            listBoxName.Items.Add(friend.Name);
                            listBoxLastPostAuthor.Items.Add(friend.Birthdate.Day + " / " + friend.Birthdate.Month);

                            //listBoxLastPost.Items.Add(userEvent.WallPosts[0].Description);
                            //listBoxLastPostAuthor.Items.Add(userEvent.WallPosts[0].Name);
                            //listBoxLastPostDate.Items.Add(userEvent.UpdateTime);
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
