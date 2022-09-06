using System;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormLikedPages : Form
    {
        private readonly UserData r_UserData;

        public FormLikedPages()
        {
            r_UserData = Session.Instance.UserData;
            InitializeComponent();
            HandleCreated += OnHandleCreated;
        }

        public void OnHandleCreated(object sender, EventArgs e)
        {
            listBoxPageName.Invoke(new Action(() => listBoxPageName.DisplayMember = "Name"));
            foreach (Page page in r_UserData.GetSortedPagesList(eSortBy.Count))
            {
                listBoxPageName.Invoke(new Action(() => listBoxPageName.Items.Add(page)));
            }
        }

        private void listBoxPage_Clicked(object sender, EventArgs e)
        {
            ListBox groupChosen = sender as ListBox;

            foreach (Page page in r_UserData.GetSortedPagesList(eSortBy.Count))
            {
                if(groupChosen == null)
                {
                    pictureBoxPage.Image = Properties.Resources.placeholderpicture;
                }
                else if (groupChosen.SelectedItem.ToString() == page.ToString())
                {
                    pictureBoxPage.Image = page.ImageLarge;
                }
            }
        }
    }
}
