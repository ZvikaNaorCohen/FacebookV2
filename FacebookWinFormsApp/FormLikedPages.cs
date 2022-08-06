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
    public partial class FormLikedPages : Form
    {
        private Session m_LoginSession;

        public FormLikedPages(Session i_LoginSession)
        {
            m_LoginSession = i_LoginSession;
            InitializeComponent();
        }

        public void FetchInfo()
        {
            UserData userData = m_LoginSession.UserData;
            listBoxPageName.DisplayMember = "Name";
            foreach (Page page in userData.GetSortedPagesList(eSortBy.Count))
            {
                listBoxPageName.Items.Add(page);
            }
        }

        private void listBoxPage_Clicked(object sender, EventArgs e)
        {
            ListBox groupChosen = sender as ListBox;
            UserData userData = m_LoginSession.UserData;
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
