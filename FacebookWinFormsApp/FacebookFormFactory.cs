using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal static class FacebookFormFactory
    {
        internal static Form CreateNewFacebookForm(string i_FormType)
        {
            Form newFacebookForm;

            switch(i_FormType)
            {
                case "Main":
                    newFacebookForm = new FormMain();
                    break;
                case "Login":
                    newFacebookForm = new FormLogin();
                    break;
                case "Albums":
                    newFacebookForm = new FormAlbums();
                    break;
                case "Groups":
                    newFacebookForm = new FormGroups();
                    break;
                case "Pages":
                    newFacebookForm = new FormLikedPages();
                    break;
                case "Birthdays":
                    newFacebookForm = new FormBirthdays();
                    break;
                default:
                    newFacebookForm = null;
                    break;
            }

            return newFacebookForm;
        }
    }
}
