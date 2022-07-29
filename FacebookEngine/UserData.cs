using System.Collections.Generic;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookEngine
{
    public class UserData
    {
        private const uint k_DummyFriendsCount = 5u;
        private UserInformation m_UserInfo;
        private Image m_UserCoverPhoto;
        private Image m_UserProfilePicture;
        private FriendList m_UserFriendsList;
        private FacebookObjectCollection<Group> m_UserJoinedGroupsList;
        private FacebookObjectCollection<Album> m_UserAlbumsList;

        public UserData(User i_FacebookUser)
        {
            m_UserInfo = new UserInformation(i_FacebookUser);
            m_UserProfilePicture = i_FacebookUser.ImageSmall;
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

                foreach (User friend in m_UserFriendsList.Members)
                {
                    friendList.Add(friend);
                }

                return friendList;
            }
        }

        private void generateDummyFriendsList(uint i_FriendCount)
        {
            for(uint i = 0u; i < i_FriendCount; ++i)
            {
                User newFriend = new User
                {
                    Name = $"Friend #{i}",
                };
                m_UserFriendsList.Members.Add(newFriend);
            }
        }
    }
}
