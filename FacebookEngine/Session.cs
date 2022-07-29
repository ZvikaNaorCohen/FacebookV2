using System;

namespace FacebookEngine
{
    public class Session
    {
        private FacebookWrapper.ObjectModel.User m_CurrentlyLoggedInUser;
        private DateTime m_LastLoginTime;
    }
}
