using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookEngine
{
    [Serializable]
    public class Session
    {
        private const string k_SessionFileName = "fbsession.bin";
        private User m_CurrentlyLoggedInUser;
        private DateTime m_LastLoginTime;
        // private string m_AccessToken;
        private UserData m_UserData;

        public string AccessToken { get; set; }

        public bool RememberMe { get; set; }

        public Session()
        {
            m_CurrentlyLoggedInUser = null;
            m_UserData = null;
            AccessToken = string.Empty;
            m_LastLoginTime = DateTime.MinValue;
            RememberMe = false;
        }

        public static Session LoadFromFile()
        {
            using (Stream fileStream = new FileStream(k_SessionFileName, FileMode.Truncate))
            {
                IFormatter binaryFormatter = new BinaryFormatter();
                return binaryFormatter.Deserialize(fileStream) as Session;
            }
        }

        public void Initialize(LoginResult i_UserLogin)
        {
            m_LastLoginTime = DateTime.Now;
            m_CurrentlyLoggedInUser = i_UserLogin.LoggedInUser;
            AccessToken = i_UserLogin.AccessToken;
            fetchUserData();
        }

        public void Terminate(bool i_RememberUser)
        {
            m_CurrentlyLoggedInUser = null;
            m_UserData = null;
            if(i_RememberUser)
            {
                SaveToFile();
            }
        }

        public void SaveToFile()
        {
            using(Stream fileStream = new FileStream(k_SessionFileName, FileMode.Truncate))
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
