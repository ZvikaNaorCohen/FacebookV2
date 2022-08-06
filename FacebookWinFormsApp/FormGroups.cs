using System;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormGroups : Form
    {
        private Session m_LoginSession;

        public FormGroups(Session i_LoginSession)
        {
            m_LoginSession = i_LoginSession;
            InitializeComponent();
        }

        public void FetchInfo()
        {
            UserData userData = m_LoginSession.UserData;
            resetAllListBoxes();
            listBoxName.DisplayMember = "Name";
            foreach(Group group in userData.GetSortedGroupsList(eSortBy.Name))
            {
                listBoxName.Items.Add(group);
                if(!string.IsNullOrEmpty(group.Description))
                {
                    listBoxDescription.Items.Add(group.Description);
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
            UserData userData = m_LoginSession.UserData;
            foreach (Group group in userData.GetSortedGroupsList(eSortBy.Name))
            {
                if(groupChosen.SelectedItem.ToString() == group.Name)
                {
                    pictureBoxGroup.Image = group.ImageLarge;
                }
            }

        }
    }
}
