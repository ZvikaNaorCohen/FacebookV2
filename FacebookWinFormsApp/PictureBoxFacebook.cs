using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PictureBoxFacebook : PictureBox
    {
        private const int k_PaddingSize = 0;

        internal PictureBoxFacebook(Photo i_FacebookPhoto, int i_PhotoSize)
        {
            Image = Properties.Resources.placeholderpicture;
            new Thread(() => loadImage(i_FacebookPhoto)).Start();
            Margin = new Padding(k_PaddingSize);
            Size = new Size(i_PhotoSize, i_PhotoSize);
        }

        internal Image Photo { get; private set; }

        internal Image Thumbnail { get; private set; }

        private void loadImage(Photo i_FacebookPhoto)
        {
            Thumbnail = Image = i_FacebookPhoto.ImageThumb;
            Photo = i_FacebookPhoto.ImageNormal;
        }
    }
}
