using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class FormImage : Form
    {
        private PictureBox m_PictureBoxUserImage;

        internal FormImage(Image i_Image)
        {
            initializeComponent();
            Icon = Properties.Resources.Picture;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ClientSize = i_Image.Size;
            m_PictureBoxUserImage.Image = i_Image;
        }

        private void initializeComponent()
        {
            this.m_PictureBoxUserImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)this.m_PictureBoxUserImage).BeginInit();
            this.SuspendLayout();

            // pictureBoxUserImage
            this.m_PictureBoxUserImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_PictureBoxUserImage.Location = new System.Drawing.Point(0, 0);
            this.m_PictureBoxUserImage.Margin = new System.Windows.Forms.Padding(0);
            this.m_PictureBoxUserImage.Name = "pictureBoxUserImage";
            this.m_PictureBoxUserImage.Size = new System.Drawing.Size(282, 253);
            this.m_PictureBoxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.m_PictureBoxUserImage.TabIndex = 0;
            this.m_PictureBoxUserImage.TabStop = false;

            // FormImage
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.m_PictureBoxUserImage);
            this.Name = "FormImage";
            ((System.ComponentModel.ISupportInitialize)this.m_PictureBoxUserImage).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
