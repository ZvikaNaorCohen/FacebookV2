using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookEngine
{
    [Serializable]
    public class Session
    {
        private User m_CurrentlyLoggedInUser;
        private UserData m_UserData;
        private DateTime m_LastLoginTime;
        private string m_AccessToken;

        public Session()
        {
            m_CurrentlyLoggedInUser = null;
            m_AccessToken = string.Empty;
            m_LastLoginTime = DateTime.MinValue;
        }

        public static Session LoadFromFile()
        {
            using (Stream fileStream = new FileStream("fbsession.bin", FileMode.Truncate))
            {
                IFormatter binaryFormatter = new BinaryFormatter();
                return binaryFormatter.Deserialize(fileStream) as Session;
            }
        }

        public void Initialize(LoginResult i_UserLogin)
        {
            m_LastLoginTime = DateTime.Now;
            m_CurrentlyLoggedInUser = i_UserLogin.LoggedInUser;
            m_AccessToken = i_UserLogin.AccessToken;
        }

        public void Terminate()
        {
            m_CurrentlyLoggedInUser = null;
        }

        public void SaveToFile()
        {
            using(Stream fileStream = new FileStream("fbsession.bin", FileMode.Truncate))
            {
                IFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, this);
            }
        }

        private void fetchUserData()
        {
            m_UserData = new UserData(m_CurrentlyLoggedInUser);
        }
    }
}
