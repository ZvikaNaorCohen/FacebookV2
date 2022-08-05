using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class ButtonAlbum : Button
    {
        private const int k_PaddingSize = 0;

        internal ButtonAlbum(Album i_Album, int i_ThumbnailSize)
        {
            Album = i_Album;
            Margin = new Padding(k_PaddingSize);
            Size = new Size(i_ThumbnailSize, i_ThumbnailSize);
            FlatStyle = FlatStyle.Flat;
        }

        public Album Album { get; }
    }
}
