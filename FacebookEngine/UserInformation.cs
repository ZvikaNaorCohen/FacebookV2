using FacebookWrapper.ObjectModel;

namespace FacebookEngine
{
    public class UserInformation
    {
        public UserInformation(User i_FacebookUser)
        {
            Name = i_FacebookUser.Name;
            Email = i_FacebookUser.Email;
            Birthday = i_FacebookUser.Birthday;
        }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Birthday { get; private set; }
    }
}
