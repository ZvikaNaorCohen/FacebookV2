using System;
using FacebookWrapper.ObjectModel;

namespace FacebookEngine
{
    [Serializable]
    public class UserInformation
    {
        public UserInformation(User i_FacebookUser)
        {
            Name = i_FacebookUser.Name;
            Email = i_FacebookUser.Email;
            Birthday = i_FacebookUser.Birthday;
            Gender = i_FacebookUser.Gender.ToString();
            //Hometown = i_FacebookUser.Hometown.ToString();
            Hometown = "LaLaLand";
            RelationshipStatus = i_FacebookUser.RelationshipStatus.ToString();
            //InterestedIn = i_FacebookUser.InterestedIn.ToString();
            InterestedIn = "C# .Net";
        }

        public string Name { get; }

        public string Email { get; }

        public string Birthday { get; }

        public string Gender { get; }

        public string Hometown { get; }

        public string RelationshipStatus { get; }

        public string InterestedIn { get; }
    }
}
