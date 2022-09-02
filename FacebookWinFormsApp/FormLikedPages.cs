using System;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormLikedPages : Form
    {
        private readonly Session r_LoginSession;

        public FormLikedPages(Session i_LoginSession)
        {
            r_LoginSession = i_LoginSession;
            InitializeComponent();
            this.HandleCreated += new EventHandler(OnHandleCreated);
        }

        public void OnHandleCreated(object sender, EventArgs e)
        {
            UserData userData = r_LoginSession.UserData;

            listBoxPageName.Invoke(new Action(() => listBoxPageName.DisplayMember = "Name"));
            foreach (Page page in userData.GetSortedPagesList(eSortBy.Count))
            {
                listBoxPageName.Invoke(new Action(() => listBoxPageName.Items.Add(page)));
                //listBoxPageName.Items.Add(page);
            }
        }

        private void listBoxPage_Clicked(object sender, EventArgs e)
        {
            ListBox groupChosen = sender as ListBox;
            UserData userData = r_LoginSession.UserData;

            foreach (Page page in userData.GetSortedPagesList(eSortBy.Count))
            {
                if (groupChosen.SelectedItem.ToString() == page.ToString())
                {
                    pictureBoxPage.Image = page.ImageLarge;
                }
            }
        }
    }
}
