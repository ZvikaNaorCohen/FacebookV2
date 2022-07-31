using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookEngine
{
    public class UserData
    {
        private const uint k_DummyFriendsCount = 5u;
        private UserInformation m_UserInfo;
        private Image m_UserCoverPhoto;
        private Image m_UserProfilePicture;
        private FacebookObjectCollection<User> m_UserFriendsList;
        private FacebookObjectCollection<Group> m_UserJoinedGroupsList;
        private FacebookObjectCollection<Album> m_UserAlbumsList;

        public UserData(User i_FacebookUser)
        {
            m_UserInfo = new UserInformation(i_FacebookUser);
            m_UserProfilePicture = i_FacebookUser.ImageSmall;
            m_UserCoverPhoto = new Bitmap("dummycoverphoto.bmp");
            m_UserFriendsList = new FacebookObjectCollection<User>();
            m_UserJoinedGroupsList = i_FacebookUser.Groups;
            m_UserAlbumsList = i_FacebookUser.Albums;
            generateDummyFriendsList(k_DummyFriendsCount);
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

        private void generateDummyFriendsList(uint i_FriendCount)
        {
            for(uint i = 0u; i < i_FriendCount; ++i)
            {
                User newFriend = new User
                {
                    Name = $"Friend #{i}",
                };
                m_UserFriendsList.Add(newFriend);
            }
        }
    }
}
