using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PictureBoxFacebook : PictureBox
    {
        private const int k_PaddingSize = 0;

        internal PictureBoxFacebook(Photo i_FacebookPhoto, int i_PhotoSize)
        {
            Photo = i_FacebookPhoto.ImageNormal;
            Thumbnail = i_FacebookPhoto.ImageThumb;
            Image = Thumbnail;
            Margin = new Padding(k_PaddingSize);
            Size = new Size(i_PhotoSize, i_PhotoSize);
        }

        internal Image Photo { get; }

        internal Image Thumbnail { get; }
    }
}
