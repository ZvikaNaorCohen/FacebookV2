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
        private const int k_AlbumTableTop = 0;
        private readonly UserData r_UserData;
        private TableLayoutPanel m_TableLayoutPanelAlbum;

        internal FormAlbums(UserData i_UserData)
        {
            r_UserData = i_UserData;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Icon = Properties.Resources.Album;
            initializeComponent();
        }

        private void initializeComponent()
        {
            m_TableLayoutPanelAlbum = new TableLayoutPanel();
            m_TableLayoutPanelAlbum.Top = k_AlbumTableTop;
            Controls.Add(m_TableLayoutPanelAlbum);
            showAllAlbums();
        }

        private void showAllAlbums()
        {
            resizeAlbumTable((int)Math.Sqrt(r_UserData.GetSortedAlbumsList(eSortBy.Name).Count));
            foreach (Album album in r_UserData.GetSortedAlbumsList(eSortBy.Name))
            {
                ButtonAlbum albumButton = new ButtonAlbum(album, k_PictureSize);
                albumButton.Dock = DockStyle.Fill;
                albumButton.Text = album.Name;
                albumButton.Click += buttonAlbum_Clicked;
                m_TableLayoutPanelAlbum.Controls.Add(albumButton);
            }
        }

        private void showAlbum(Album i_Album)
        {
            resizeAlbumTable((int)Math.Sqrt(i_Album.Photos.Count));
            m_TableLayoutPanelAlbum.Controls.Clear();
            foreach(Photo photo in i_Album.Photos)
            {
                PictureBoxFacebook facebookPicture = new PictureBoxFacebook(photo, k_PictureSize);
                facebookPicture.Dock = DockStyle.Fill;
                facebookPicture.Click += pictureBox_Clicked;
                m_TableLayoutPanelAlbum.Controls.Add(facebookPicture);
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
            m_TableLayoutPanelAlbum.ColumnCount = m_TableLayoutPanelAlbum.RowCount = i_RowAndColumnCount + k_MinTableSize;
            m_TableLayoutPanelAlbum.Size = new Size(
                m_TableLayoutPanelAlbum.RowCount * k_PictureSize,
                m_TableLayoutPanelAlbum.ColumnCount * k_PictureSize);
        }
    }
}
