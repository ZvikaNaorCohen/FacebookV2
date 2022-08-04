using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FormAlbums : Form
    {
        private UserData m_UserData;

        internal FormAlbums(UserData i_UserData)
        {
            m_UserData = i_UserData;
            InitializeComponent();
        }

        private void InitializeComponent()
        {

        }

        private void loadAlbums()
        {
            foreach(Album album in m_UserData.GetSortedAlbumsList(eSortBy.Name))
            {
                // Albums
            }
        }
    }
}
