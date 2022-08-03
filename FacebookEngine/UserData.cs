using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookEngine
{
    public class UserData
    {
        private const uint k_DummyFriendsCount = 8u;
        private const string k_DummyCoverPhoto = "dummycoverphoto.bmp";
        private UserInformation m_UserInfo;
        private Image m_UserCoverPhoto;
        private Image m_UserProfilePicture;
        private FacebookObjectCollection<User> m_UserFriendsList;
        private FacebookObjectCollection<Group> m_UserJoinedGroupsList;
        private FacebookObjectCollection<Album> m_UserAlbumsList;
        private FacebookObjectCollection<Page> m_UserPagesList;
        private FacebookObjectCollection<Event> m_UserEventsList;
        private List<FriendsDummy> m_UserDummyFriendsList = new List<FriendsDummy>();

        public UserData(User i_FacebookUser)
        {
            m_UserInfo = new UserInformation(i_FacebookUser);
            m_UserProfilePicture = i_FacebookUser.ImageNormal;
            // UserCoverPhoto = new Bitmap(k_DummyCoverPhoto);
            m_UserFriendsList = new FacebookObjectCollection<User>();
            m_UserJoinedGroupsList = i_FacebookUser.Groups;
            m_UserAlbumsList = i_FacebookUser.Albums;
            m_UserPagesList = i_FacebookUser.LikedPages;
            m_UserEventsList = i_FacebookUser.Events;
            generateDummyFriendsList(k_DummyFriendsCount);
        }

        public List<FriendsDummy> UserDummyFriendsList
        {
            get
            {
                return m_UserDummyFriendsList;
            }
        }

        public UserInformation UserInformation
        {
            get
            {
                return m_UserInfo;
            }
        }

        public Image CoverPhoto
        {
            get
            {
                return m_UserCoverPhoto;
            }
        }

        public Image ProfilePicture
        {
            get
            {
                return m_UserProfilePicture;
            }
        }

        public List<User> FriendList
        {
            get
            {
                List<User> friendList = new List<User>();

                foreach (User friend in m_UserFriendsList)
                {
                    friendList.Add(friend);
                }

                return friendList;
            }
        }

        public List<Group> GetSortedGroupsList(eSortBy i_SortBy)
        {
            List<Group> sortedGroupList;

            switch(i_SortBy)
            {
                case eSortBy.Members:
                    sortedGroupList = m_UserJoinedGroupsList.OrderBy(i_Group => i_Group.Members.Count).ToList();
                    break;
                case eSortBy.LastUpdated:
                    sortedGroupList = m_UserJoinedGroupsList.OrderBy(i_Group => i_Group.UpdateTime).ToList();
                    break;
                default:
                    sortedGroupList = m_UserJoinedGroupsList.OrderBy(i_Group => i_Group.Name).ToList();
                    break;
            }

            return sortedGroupList;
        }

        public List<Album> GetSortedAlbumsList(eSortBy i_SortBy)
        {
            List<Album> sortedAlbumList;

            switch(i_SortBy)
            {
                case eSortBy.Count:
                    sortedAlbumList = m_UserAlbumsList.OrderBy(i_Album => i_Album.Count).ToList();
                    break;
                case eSortBy.LastUpdated:
                    sortedAlbumList = m_UserAlbumsList.OrderBy(i_Album => i_Album.UpdateTime).ToList();
                    break;
                default:
                    sortedAlbumList = m_UserAlbumsList.OrderBy(i_Album => i_Album.Name).ToList();
                    break;
            }

            return sortedAlbumList;
        }

        public List<Event> GetSortedEventsList(eSortBy i_SortBy)
        {
            List<Event> sortedEventList;

            switch (i_SortBy)
            {
                case eSortBy.Count:
                    sortedEventList = m_UserEventsList.OrderBy(i_Event => i_Event.AttendingCount).ToList();
                    break;
                case eSortBy.LastUpdated:
                    sortedEventList = m_UserEventsList.OrderBy(i_Event => i_Event.UpdateTime).ToList();
                    break;
                default:
                    sortedEventList = m_UserEventsList.OrderBy(i_Event => i_Event.Name).ToList();
                    break;
            }

            return sortedEventList;
        }

        public List<Page> GetSortedPagesList(eSortBy i_SortBy)
        {
            List<Page> sortedPagesList;

            switch (i_SortBy)
            {
                case eSortBy.Count:
                    sortedPagesList = m_UserPagesList.OrderBy(i_Page => i_Page.LikesCount).ToList();
                    break;
                default:
                    sortedPagesList = m_UserPagesList.OrderBy(i_Page => i_Page.Name).ToList();
                    break;
            }

            return sortedPagesList;
        }

        private void generateDummyFriendsList(uint i_FriendCount)
        {
            Random rnd = new Random(5);
            for (uint i = 0u; i < i_FriendCount; ++i)
            {
                // User newFriend = new User { Name = $"Friend #{i + 1}" };
                // m_UserFriendsList.Add(newFriend);
                m_UserDummyFriendsList.Add(new FriendsDummy(RandomGenerator.GetRandomFromType("Name"), RandomGenerator.GenerateRandomDateTime(), User.eGender.male));
            }
        }
    }
}
