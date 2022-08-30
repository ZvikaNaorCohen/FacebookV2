using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class LoginResultAdapter
    {
        private LoginResult m_LoginResult;

        private string AppId { get; set; }

        private string[] RequestedPermissions { get; set; }

        public LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }
        }

        public string AccessToken
        {
            get
            {
                return m_LoginResult.AccessToken;
            }
        }

        public LoginResultAdapter(string i_AppId, string[] i_RequestedPermissions)
        {
            AppId = i_AppId;
            RequestedPermissions = i_RequestedPermissions;
        }

        public void FacebookLogin()
        {
            m_LoginResult = FacebookService.Login(AppId, RequestedPermissions);
        }
    }
}
