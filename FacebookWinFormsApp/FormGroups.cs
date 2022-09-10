using System;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal partial class FormGroups : Form
    {
        private readonly UserData r_UserData;

        internal FormGroups()
        {
            r_UserData = Session.Instance.UserData;
            InitializeComponent();
            HandleCreated += OnHandleCreated;
        }

        private void OnHandleCreated(object sender, EventArgs e)
        {
            resetAllListBoxes();
            listBoxName.Invoke(new Action(() => listBoxName.DisplayMember = "Name"));
            foreach (Group group in r_UserData.GetSortedGroupsList(eSortBy.Name))
            {
                listBoxName.Invoke(new Action(() => listBoxName.Items.Add(group)));
                if (!string.IsNullOrEmpty(group.Description))
                {
                    listBoxDescription.Invoke(new Action(() => listBoxDescription.Items.Add(group.Description)));
                }
                else
                {
                    listBoxDescription.Items.Add("  ");
                }
            }
        }

        private void resetAllListBoxes()
        {
            listBoxDescription.Items.Clear();
            listBoxName.Items.Clear();
        }

        private void listBoxName_Clicked(object sender, EventArgs e)
        {
            ListBox groupChosen = sender as ListBox;
            foreach (Group group in r_UserData.GetSortedGroupsList(eSortBy.Name))
            {
                if(groupChosen == null)
                {
                    pictureBoxGroup.Image = Properties.Resources.placeholderpicture;
                }
                else if(groupChosen.SelectedItem.ToString() == group.Name)
                {
                    pictureBoxGroup.Image = group.ImageLarge;
                }
            }
        }
    }
}
