using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookEngine
{
    public class UserData
    {
        private const uint k_DummyFriendsCount = 25u;
        private readonly UserInformation r_UserInfo;
        private readonly Image r_UserProfilePicture;
        private readonly FacebookObjectCollection<Group> r_UserJoinedGroupsList;
        private readonly FacebookObjectCollection<Album> r_UserAlbumsList;
        private readonly FacebookObjectCollection<Page> r_UserPagesList;
        private readonly List<FriendsDummy> r_UserDummyFriendsList;

        public UserData(User i_FacebookUser)
        {
            r_UserInfo = new UserInformation(i_FacebookUser);
            r_UserProfilePicture = i_FacebookUser.ImageNormal;
            r_UserJoinedGroupsList = i_FacebookUser.Groups;
            r_UserAlbumsList = i_FacebookUser.Albums;
            r_UserPagesList = i_FacebookUser.LikedPages;
            r_UserDummyFriendsList = new List<FriendsDummy>();
            generateDummyFriendsList(k_DummyFriendsCount);
        }

        public List<FriendsDummy> UserDummyFriendsList
        {
            get
            {
                return r_UserDummyFriendsList;
            }
        }

        public UserInformation UserInformation
        {
            get
            {
                return r_UserInfo;
            }
        }

        public Image ProfilePicture
        {
            get
            {
                return r_UserProfilePicture;
            }
        }

        public List<Group> GetSortedGroupsList(eSortBy i_SortBy)
        {
            List<Group> sortedGroupList;

            switch(i_SortBy)
            {
                case eSortBy.Members:
                    sortedGroupList = r_UserJoinedGroupsList.OrderBy(i_Group => i_Group.Members.Count).ToList();
                    break;
                case eSortBy.LastUpdated:
                    sortedGroupList = r_UserJoinedGroupsList.OrderBy(i_Group => i_Group.UpdateTime).ToList();
                    break;
                default:
                    sortedGroupList = r_UserJoinedGroupsList.OrderBy(i_Group => i_Group.Name).ToList();
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
                    sortedAlbumList = r_UserAlbumsList.OrderBy(i_Album => i_Album.Count).ToList();
                    break;
                case eSortBy.LastUpdated:
                    sortedAlbumList = r_UserAlbumsList.OrderBy(i_Album => i_Album.UpdateTime).ToList();
                    break;
                default:
                    sortedAlbumList = r_UserAlbumsList.OrderBy(i_Album => i_Album.Name).ToList();
                    break;
            }

            return sortedAlbumList;
        }

        public List<Page> GetSortedPagesList(eSortBy i_SortBy)
        {
            List<Page> sortedPagesList;

            switch (i_SortBy)
            {
                case eSortBy.Count:
                    sortedPagesList = r_UserPagesList.OrderBy(i_Page => i_Page.LikesCount).ToList();
                    break;
                default:
                    sortedPagesList = r_UserPagesList.OrderBy(i_Page => i_Page.Name).ToList();
                    break;
            }

            return sortedPagesList;
        }

        private void generateDummyFriendsList(uint i_FriendCount)
        {
            for (uint i = 0u; i < i_FriendCount; ++i)
            {
                r_UserDummyFriendsList.Add(new FriendsDummy(RandomGenerator.GetRandomFromType("Name"), RandomGenerator.GenerateRandomDateTime(), User.eGender.male));
            }
        }
    }
}
