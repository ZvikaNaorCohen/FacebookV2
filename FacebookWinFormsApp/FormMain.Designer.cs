
namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.coverPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxNotifications = new System.Windows.Forms.ListBox();
            this.listBoxUserInfo = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
            this.buttonGetGroups = new System.Windows.Forms.Button();
            this.buttonGetAlbums = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.profilePictureBox.Location = new System.Drawing.Point(77, 181);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(145, 118);
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // coverPhotoPictureBox
            // 
            this.coverPhotoPictureBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.coverPhotoPictureBox.Location = new System.Drawing.Point(59, 37);
            this.coverPhotoPictureBox.Name = "coverPhotoPictureBox";
            this.coverPhotoPictureBox.Size = new System.Drawing.Size(1328, 282);
            this.coverPhotoPictureBox.TabIndex = 1;
            this.coverPhotoPictureBox.TabStop = false;
            // 
            // listBoxNotifications
            // 
            this.listBoxNotifications.FormattingEnabled = true;
            this.listBoxNotifications.ItemHeight = 20;
            this.listBoxNotifications.Location = new System.Drawing.Point(909, 46);
            this.listBoxNotifications.Name = "listBoxNotifications";
            this.listBoxNotifications.Size = new System.Drawing.Size(466, 264);
            this.listBoxNotifications.TabIndex = 2;
            this.listBoxNotifications.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxUserInfo
            // 
            this.listBoxUserInfo.FormattingEnabled = true;
            this.listBoxUserInfo.ItemHeight = 20;
            this.listBoxUserInfo.Location = new System.Drawing.Point(59, 325);
            this.listBoxUserInfo.Name = "listBoxUserInfo";
            this.listBoxUserInfo.Size = new System.Drawing.Size(1328, 164);
            this.listBoxUserInfo.TabIndex = 3;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(59, 495);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(218, 284);
            this.listBoxFriends.TabIndex = 4;
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.ItemHeight = 20;
            this.listBoxNewsFeed.Location = new System.Drawing.Point(299, 495);
            this.listBoxNewsFeed.Name = "listBoxNewsFeed";
            this.listBoxNewsFeed.Size = new System.Drawing.Size(1088, 144);
            this.listBoxNewsFeed.TabIndex = 5;
            // 
            // buttonGetGroups
            // 
            this.buttonGetGroups.Location = new System.Drawing.Point(299, 646);
            this.buttonGetGroups.Name = "buttonGetGroups";
            this.buttonGetGroups.Size = new System.Drawing.Size(145, 64);
            this.buttonGetGroups.TabIndex = 6;
            this.buttonGetGroups.Text = "Show Groups";
            this.buttonGetGroups.UseVisualStyleBackColor = true;
            // 
            // buttonGetAlbums
            // 
            this.buttonGetAlbums.Location = new System.Drawing.Point(484, 646);
            this.buttonGetAlbums.Name = "buttonGetAlbums";
            this.buttonGetAlbums.Size = new System.Drawing.Size(145, 64);
            this.buttonGetAlbums.TabIndex = 7;
            this.buttonGetAlbums.Text = "Show Albums";
            this.buttonGetAlbums.UseVisualStyleBackColor = true;
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Location = new System.Drawing.Point(674, 646);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(145, 64);
            this.buttonLikedPages.TabIndex = 8;
            this.buttonLikedPages.Text = "Show Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.Controls.Add(this.buttonLikedPages);
            this.Controls.Add(this.buttonGetAlbums);
            this.Controls.Add(this.buttonGetGroups);
            this.Controls.Add(this.listBoxNewsFeed);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.listBoxUserInfo);
            this.Controls.Add(this.listBoxNotifications);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.coverPhotoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.PictureBox coverPhotoPictureBox;
        private System.Windows.Forms.ListBox listBoxNotifications;
        private System.Windows.Forms.ListBox listBoxUserInfo;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxNewsFeed;
        private System.Windows.Forms.Button buttonGetGroups;
        private System.Windows.Forms.Button buttonGetAlbums;
        private System.Windows.Forms.Button buttonLikedPages;
    }
}