using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FormAlbums : Form
    {
        private const int k_PictureSize = 100;
        private const int k_MinTableSize = 5;
        private UserData m_UserData;
        private TableLayoutPanel albumTableLayoutPanel;

        internal FormAlbums(UserData i_UserData)
        {
            m_UserData = i_UserData;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Icon = Properties.Resources.Album;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            albumTableLayoutPanel = new TableLayoutPanel();
            albumTableLayoutPanel.Top = 0;
            Controls.Add(albumTableLayoutPanel);
            showAllAlbums();
        }

        private void showAllAlbums()
        {
            resizeAlbumTable((int)Math.Sqrt(m_UserData.GetSortedAlbumsList(eSortBy.Name).Count));
            foreach (Album album in m_UserData.GetSortedAlbumsList(eSortBy.Name))
            {
                ButtonAlbum albumButton = new ButtonAlbum(album, k_PictureSize);

                albumButton.Dock = DockStyle.Fill;
                albumButton.Text = album.Name;
                albumButton.Click += buttonAlbum_Clicked;
                albumTableLayoutPanel.Controls.Add(albumButton);
            }
        }

        private void showAlbum(Album i_Album)
        {
            resizeAlbumTable((int)Math.Sqrt(i_Album.Photos.Count));
            albumTableLayoutPanel.Controls.Clear();
            foreach(Photo photo in i_Album.Photos)
            {
                PictureBoxFacebook facebookPicture = new PictureBoxFacebook(photo, k_PictureSize);

                facebookPicture.Dock = DockStyle.Fill;
                facebookPicture.Click += pictureBox_Clicked;
                albumTableLayoutPanel.Controls.Add(facebookPicture);
            }
        }

        private void pictureBox_Clicked(object sender, EventArgs e)
        {
            if(sender is PictureBoxFacebook facebookPicture)
            {
                FormImage imageDisplay = new FormImage(facebookPicture.Photo);
                imageDisplay.ShowDialog();
            }
        }

        private void buttonAlbum_Clicked(object sender, EventArgs e)
        {
            if(sender is ButtonAlbum selectedAlbum)
            {
                showAlbum(selectedAlbum.Album);
            }
        }

        private void resizeAlbumTable(int i_RowAndColumnCount)
        {
            albumTableLayoutPanel.ColumnCount = albumTableLayoutPanel.RowCount = i_RowAndColumnCount + k_MinTableSize;
            albumTableLayoutPanel.Size = new Size(
                albumTableLayoutPanel.RowCount * k_PictureSize,
                albumTableLayoutPanel.ColumnCount * k_PictureSize);
        }
    }
}
