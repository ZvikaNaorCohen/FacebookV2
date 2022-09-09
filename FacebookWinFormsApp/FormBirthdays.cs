using System;
using System.Text;
using System.Windows.Forms;
using FacebookEngine;

namespace BasicFacebookFeatures
{
    internal partial class FormBirthdays : Form
    {
        private readonly UserData r_UserData;

        internal FormBirthdays()
        {
            r_UserData = Session.Instance.UserData;
            InitializeComponent();
            HandleCreated += OnHandleCreated;
        }

        internal void OnHandleCreated(object sender, EventArgs e)
        {
            updateBirthdaysList(eSortBy.Name);
        }

        private void updateBirthdaysList(eSortBy i_SortBy)
        {
            listBoxName.Items.Clear();
            foreach(string birthday in r_UserData.GetSortedBirthdaysList(i_SortBy))
            {
                listBoxName.Invoke(new Action(() => listBoxName.Items.Add(birthday)));
            }
        }

        private void radioButtonAToZ_Clicked(object sender, EventArgs e)
        {
            updateBirthdaysList(eSortBy.Name);
        }

        private void radioButtonAges_Clicked(object sender, EventArgs e)
        {
            updateBirthdaysList(eSortBy.Age);
        }

        private void radioButtonDaysToBirthday_Clicked(object sender, EventArgs e)
        {
            updateBirthdaysList(eSortBy.Date);
        }

        private void listBoxName_Click(object sender, EventArgs e)
        {
            buttonPostWish.Enabled = true;
        }
    }
}
