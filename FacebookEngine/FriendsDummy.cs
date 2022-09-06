using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookEngine
{
    public class FriendsDummy
    {
        public string Name { get; }

        public DateTime Birthdate { get; }

        public User.eGender Gender { get; }

        public string LastPost { get; }

        public DateTime LastPostDate { get; }

        public List<PostsDummy> AllUserDummyPosts { get; }

        public int DaysToBirthday { get; set; }

        public bool Muted { get; set; }

        public FriendsDummy(
            string i_Name,
            DateTime i_Birthdate,
            User.eGender i_Gender)
        {
            Name = i_Name;
            Birthdate = i_Birthdate;
            Gender = i_Gender;
            AllUserDummyPosts = PostsDummy.GenerateDummyPosts(this);
            LastPost = AllUserDummyPosts[AllUserDummyPosts.Count - 1].Message;
            LastPostDate = AllUserDummyPosts[AllUserDummyPosts.Count - 1].DatePosted;
            Muted = false;
            calculateDaysUntilBirthday();
        }

        private void calculateDaysUntilBirthday()
        {
            DateTime nextBirthday = Birthdate.AddYears(DateTime.Today.Year - Birthdate.Year);

            if(nextBirthday < DateTime.Today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            DaysToBirthday = (nextBirthday - DateTime.Today).Days;
        }
    }
}
