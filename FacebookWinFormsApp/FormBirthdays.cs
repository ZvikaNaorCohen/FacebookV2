using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools.Page;
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
                friend.DaysToBirthday = daysToBirthday;
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

        private void radioButtonAToZ_Clicked(object sender, EventArgs e)
        {
            //radioButtonAToZ.Checked = true;
            //radioButtonDaysToBirthday.Checked = false;
            //radioButtonAges.Checked = false;
            sortNamesBy((sender as RadioButton).Text);
        }

        private void radioButtonAges_Clicked(object sender, EventArgs e)
        {
            //radioButtonAToZ.Checked = false;
            //radioButtonDaysToBirthday.Checked = false;
            //radioButtonAges.Checked = true;
            sortNamesBy((sender as RadioButton).Text);
        }

        private void radioButtonDaysToBirthday_Clicked(object sender, EventArgs e)
        {
            //radioButtonAToZ.Checked = false;
            //radioButtonDaysToBirthday.Checked = true;
            //radioButtonAges.Checked = false;
            sortNamesBy((sender as RadioButton).Text);
        }

        private void sortNamesBy(string i_SortOption)
        {
            UserData userData = m_LoginSession.UserData;
            listBoxName.Items.Clear();
            switch (i_SortOption)
            {
                case "A-Z":
                    {
                        listBoxName.Sorted = true;
                        break;
                    }
                case "Ages":
                    {
                        listBoxName.Sorted = false;
                        userData.UserDummyFriendsList.Sort((i_FriendOne, i_FriendTwo) => DateTime.Compare(i_FriendOne.Birthdate, i_FriendTwo.Birthdate));
                        break;
                    }
                case "Days To Birthday":
                    {
                        listBoxName.Sorted = false;
                        userData.UserDummyFriendsList.Sort((i_FriendOne, i_FriendTwo) => i_FriendOne.DaysToBirthday.CompareTo(i_FriendTwo.DaysToBirthday));
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            FetchInfo();
        }
    }
}
