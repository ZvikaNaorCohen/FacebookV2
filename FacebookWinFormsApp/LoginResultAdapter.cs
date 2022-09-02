using FacebookWrapper;

namespace BasicFacebookFeatures
{
    internal class LoginResultAdapter
    {
        private LoginResult m_LoginResult;

        private string AppId { get; set; }

        private string[] RequestedPermissions { get; set; }

        internal LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }
        }

        internal string AccessToken
        {
            get
            {
                return m_LoginResult.AccessToken;
            }
        }

        internal LoginResultAdapter(string i_AppId, string[] i_RequestedPermissions)
        {
            AppId = i_AppId;
            RequestedPermissions = i_RequestedPermissions;
        }

        internal void FacebookLogin()
        {
            m_LoginResult = FacebookService.Login(AppId, RequestedPermissions);
        }
    }
}
