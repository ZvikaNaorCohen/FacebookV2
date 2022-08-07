using FacebookWrapper.ObjectModel;

namespace FacebookEngine
{
    public class UserInformation
    {
        private const string k_DummyHometown = ".Net City";
        private const string k_DummyInterestedIn = "C# .Net";

        public UserInformation(User i_FacebookUser)
        {
            Name = i_FacebookUser.Name;
            Email = i_FacebookUser.Email;
            Birthday = i_FacebookUser.Birthday == string.Empty ? "01/01/2000" : i_FacebookUser.Birthday;
            Gender = i_FacebookUser.Gender.ToString();
            Hometown = k_DummyHometown;
            RelationshipStatus = i_FacebookUser.RelationshipStatus.ToString();
            InterestedIn = k_DummyInterestedIn;
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
