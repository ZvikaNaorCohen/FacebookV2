
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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.coverPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxUserInfo = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
            this.buttonGetGroups = new System.Windows.Forms.Button();
            this.buttonGetAlbums = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.checkBoxKeepLoggedIn = new System.Windows.Forms.CheckBox();
            this.buttonShowBirthdays = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBoxProfile.Location = new System.Drawing.Point(28, 185);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(129, 94);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // coverPhotoPictureBox
            // 
            this.coverPhotoPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.coverPhotoPictureBox.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.dummycoverphoto;
            this.coverPhotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverPhotoPictureBox.Location = new System.Drawing.Point(28, 18);
            this.coverPhotoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coverPhotoPictureBox.Name = "coverPhotoPictureBox";
            this.coverPhotoPictureBox.Size = new System.Drawing.Size(996, 210);
            this.coverPhotoPictureBox.TabIndex = 1;
            this.coverPhotoPictureBox.TabStop = false;
            // 
            // listBoxUserInfo
            // 
            this.listBoxUserInfo.FormattingEnabled = true;
            this.listBoxUserInfo.ItemHeight = 16;
            this.listBoxUserInfo.Location = new System.Drawing.Point(28, 283);
            this.listBoxUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxUserInfo.Name = "listBoxUserInfo";
            this.listBoxUserInfo.Size = new System.Drawing.Size(997, 132);
            this.listBoxUserInfo.TabIndex = 3;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(28, 438);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(194, 212);
            this.listBoxFriends.TabIndex = 4;
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.ItemHeight = 16;
            this.listBoxNewsFeed.Location = new System.Drawing.Point(242, 438);
            this.listBoxNewsFeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxNewsFeed.Name = "listBoxNewsFeed";
            this.listBoxNewsFeed.Size = new System.Drawing.Size(783, 116);
            this.listBoxNewsFeed.TabIndex = 5;
            // 
            // buttonGetGroups
            // 
            this.buttonGetGroups.Location = new System.Drawing.Point(403, 586);
            this.buttonGetGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGetGroups.Name = "buttonGetGroups";
            this.buttonGetGroups.Size = new System.Drawing.Size(142, 64);
            this.buttonGetGroups.TabIndex = 6;
            this.buttonGetGroups.Text = "Show Groups";
            this.buttonGetGroups.UseVisualStyleBackColor = true;
            this.buttonGetGroups.Click += new System.EventHandler(this.buttonGetGroups_Clicked);
            // 
            // buttonGetAlbums
            // 
            this.buttonGetAlbums.Location = new System.Drawing.Point(242, 586);
            this.buttonGetAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGetAlbums.Name = "buttonGetAlbums";
            this.buttonGetAlbums.Size = new System.Drawing.Size(142, 64);
            this.buttonGetAlbums.TabIndex = 7;
            this.buttonGetAlbums.Text = "Show Albums";
            this.buttonGetAlbums.UseVisualStyleBackColor = true;
            this.buttonGetAlbums.Click += new System.EventHandler(this.buttonGetAlbums_Clicked);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Location = new System.Drawing.Point(567, 586);
            this.buttonLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(142, 64);
            this.buttonLikedPages.TabIndex = 8;
            this.buttonLikedPages.Text = "Show Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = true;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonGetPages_Clicked);
            // 
            // labelFullName
            // 
            this.labelFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFullName.ForeColor = System.Drawing.Color.Black;
            this.labelFullName.Location = new System.Drawing.Point(163, 239);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(675, 35);
            this.labelFullName.TabIndex = 9;
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxKeepLoggedIn
            // 
            this.checkBoxKeepLoggedIn.Location = new System.Drawing.Point(860, 248);
            this.checkBoxKeepLoggedIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxKeepLoggedIn.Name = "checkBoxKeepLoggedIn";
            this.checkBoxKeepLoggedIn.Size = new System.Drawing.Size(164, 26);
            this.checkBoxKeepLoggedIn.TabIndex = 10;
            this.checkBoxKeepLoggedIn.Text = "Keep Me Logged In";
            this.checkBoxKeepLoggedIn.UseVisualStyleBackColor = true;
            this.checkBoxKeepLoggedIn.CheckedChanged += new System.EventHandler(this.checkBoxKeepLoggedIn_CheckedChanged);
            // 
            // buttonShowBirthdays
            // 
            this.buttonShowBirthdays.Location = new System.Drawing.Point(737, 586);
            this.buttonShowBirthdays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowBirthdays.Name = "buttonShowBirthdays";
            this.buttonShowBirthdays.Size = new System.Drawing.Size(142, 64);
            this.buttonShowBirthdays.TabIndex = 12;
            this.buttonShowBirthdays.Text = "Show Closest Birthdays";
            this.buttonShowBirthdays.UseVisualStyleBackColor = true;
            this.buttonShowBirthdays.Click += new System.EventHandler(this.buttonClosestBirthdays_Clicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 691);
            this.Controls.Add(this.buttonShowBirthdays);
            this.Controls.Add(this.checkBoxKeepLoggedIn);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.buttonLikedPages);
            this.Controls.Add(this.buttonGetAlbums);
            this.Controls.Add(this.buttonGetGroups);
            this.Controls.Add(this.listBoxNewsFeed);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.listBoxUserInfo);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.coverPhotoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox coverPhotoPictureBox;
        private System.Windows.Forms.ListBox listBoxUserInfo;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxNewsFeed;
        private System.Windows.Forms.Button buttonGetGroups;
        private System.Windows.Forms.Button buttonGetAlbums;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.CheckBox checkBoxKeepLoggedIn;
        private System.Windows.Forms.Button buttonShowBirthdays;
    }
}