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
        private TableLayoutPanel tableLayoutPanelAlbum;

        internal FormAlbums(UserData i_UserData)
        {
            r_UserData = i_UserData;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Icon = Properties.Resources.Album;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            tableLayoutPanelAlbum = new TableLayoutPanel();
            tableLayoutPanelAlbum.Top = k_AlbumTableTop;
            Controls.Add(tableLayoutPanelAlbum);
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
                tableLayoutPanelAlbum.Controls.Add(albumButton);
            }
        }

        private void showAlbum(Album i_Album)
        {
            resizeAlbumTable((int)Math.Sqrt(i_Album.Photos.Count));
            tableLayoutPanelAlbum.Controls.Clear();
            foreach(Photo photo in i_Album.Photos)
            {
                PictureBoxFacebook facebookPicture = new PictureBoxFacebook(photo, k_PictureSize);

                facebookPicture.Dock = DockStyle.Fill;
                facebookPicture.Click += pictureBox_Clicked;
                tableLayoutPanelAlbum.Controls.Add(facebookPicture);
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
            tableLayoutPanelAlbum.ColumnCount = tableLayoutPanelAlbum.RowCount = i_RowAndColumnCount + k_MinTableSize;
            tableLayoutPanelAlbum.Size = new Size(
                tableLayoutPanelAlbum.RowCount * k_PictureSize,
                tableLayoutPanelAlbum.ColumnCount * k_PictureSize);
        }
    }
}
