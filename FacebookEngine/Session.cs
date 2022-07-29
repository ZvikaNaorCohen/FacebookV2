using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookEngine
{
    public class Session
    {
        private User m_CurrentlyLoggedInUser;
        private DateTime m_LastLoginTime;

        public Session()
        {
            m_CurrentlyLoggedInUser = null;
            m_LastLoginTime = DateTime.MinValue;
        }

        public void Initialize(LoginResult i_UserLogin)
        {
            m_LastLoginTime = DateTime.Now;
            m_CurrentlyLoggedInUser = i_UserLogin.LoggedInUser;
        }

        public void Terminate()
        {
            m_CurrentlyLoggedInUser = null;
        }
    }
}
