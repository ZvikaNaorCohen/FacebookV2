using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class FormImage : Form
    {
        private PictureBox pictureBoxUserImage;

        internal FormImage(Image i_Image)
        {
            InitializeComponent();
            Icon = Properties.Resources.Picture;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ClientSize = i_Image.Size;
            pictureBoxUserImage.Image = i_Image;
        }

        private void InitializeComponent()
        {
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxUserImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUserImage.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(282, 253);
            this.pictureBoxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUserImage.TabIndex = 0;
            this.pictureBoxUserImage.TabStop = false;
            // 
            // FormImage
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.pictureBoxUserImage);
            this.Name = "FormImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
