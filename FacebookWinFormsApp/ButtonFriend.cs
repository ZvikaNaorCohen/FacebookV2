using System.Drawing;
using System.Windows.Forms;
using FacebookEngine;

namespace BasicFacebookFeatures
{
    internal class ButtonFriend : Button
    {
        private const int k_PaddingSize = 0;
        private const int k_ItemWidth = 140;
        private const int k_ItemHeight = 30;
        private readonly FriendsDummy r_Friend;

        internal ButtonFriend(FriendsDummy i_Friend)
        {
            r_Friend = i_Friend;
            Margin = new Padding(k_PaddingSize);
            Padding = new Padding(k_PaddingSize);
            Size = new Size(k_ItemWidth, k_ItemHeight);
            FlatStyle = FlatStyle.Flat;
            TextImageRelation = TextImageRelation.ImageBeforeText;
            ImageAlign = ContentAlignment.TopLeft;
            Image = Properties.Resources.usermessage;
        }

        internal void SwitchNewsState()
        {
            if(!r_Friend.Muted)
            {
                Image = Properties.Resources.block;
                r_Friend.Muted = true;
            }
            else
            {
                Image = Properties.Resources.usermessage;
                r_Friend.Muted = false;
            }
        }
    }
}
