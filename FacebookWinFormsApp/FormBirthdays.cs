using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormBirthdays : Form
    {
        private Session m_LoginSession;

        public FormBirthdays(Session i_LoginSession)
        {
            m_LoginSession = i_LoginSession;
            InitializeComponent();
        }

        public void FetchInfo()
        {
            UserData userData = m_LoginSession.UserData;
            listBoxName.Items.Clear();
            foreach(FriendsDummy friend in userData.UserDummyFriendsList)
            {
                // Calculate days to birthday
                int daysToBirthday = getDaysUntilBirthday(friend.Birthdate);
                StringBuilder stringToAdd = new StringBuilder();
                stringToAdd.Append(friend.Name);
                stringToAdd.Append("    ||    ");
                stringToAdd.Append(friend.Birthdate.Day.ToString());
                stringToAdd.Append(".");
                stringToAdd.Append(friend.Birthdate.Month.ToString());
                stringToAdd.Append(".");
                stringToAdd.Append(friend.Birthdate.Year.ToString());
                stringToAdd.Append("    ||    ");
                stringToAdd.Append(daysToBirthday.ToString());
                stringToAdd.Append(" Days to birthday. ");
                listBoxName.Items.Add(stringToAdd);
            }
        }

        private static int getDaysUntilBirthday(DateTime i_Birthday)
        {
            DateTime nextBirthday = i_Birthday.AddYears(DateTime.Today.Year - i_Birthday.Year);
            if (nextBirthday < DateTime.Today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            return (nextBirthday - DateTime.Today).Days;
        }


    }
}
