using System.Drawing;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FormAlbums : Form
    {
        private const int k_PictureSize = 100;
        private UserData m_UserData;
        private TableLayoutPanel albumTableLayoutPanel;

        internal FormAlbums(UserData i_UserData)
        {
            m_UserData = i_UserData;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            albumTableLayoutPanel = new TableLayoutPanel();
            albumTableLayoutPanel.Top = 0;
            Controls.Add(albumTableLayoutPanel);
            showAlbums();
        }

        private void showAlbums()
        {
            albumTableLayoutPanel.ColumnCount =
                albumTableLayoutPanel.RowCount = m_UserData.GetSortedAlbumsList(eSortBy.Name).Count;
            albumTableLayoutPanel.Size = new Size(
                albumTableLayoutPanel.RowCount * k_PictureSize,
                albumTableLayoutPanel.ColumnCount * k_PictureSize);
            foreach (Album album in m_UserData.GetSortedAlbumsList(eSortBy.Name))
            {
                Button albumButton = new Button();

                albumButton.Margin = new Padding(0);
                albumButton.Size = new Size(k_PictureSize, k_PictureSize);
                albumButton.FlatStyle = FlatStyle.Flat;
                albumButton.Dock = DockStyle.Fill;
                albumButton.Text = album.Name;
                albumTableLayoutPanel.Controls.Add(albumButton);
            }
        }
    }
}
