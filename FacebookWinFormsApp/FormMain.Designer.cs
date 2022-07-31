
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
            this.listBoxNotifications = new System.Windows.Forms.ListBox();
            this.listBoxUserInfo = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
            this.buttonGetGroups = new System.Windows.Forms.Button();
            this.buttonGetAlbums = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.checkBoxKeepLoggedIn = new System.Windows.Forms.CheckBox();
            this.buttonShowEvents = new System.Windows.Forms.Button();
            this.buttonShowBirthdays = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBoxProfile.Location = new System.Drawing.Point(49, 157);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(145, 118);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // coverPhotoPictureBox
            // 
            this.coverPhotoPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.coverPhotoPictureBox.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.dummycoverphoto;
            this.coverPhotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverPhotoPictureBox.Location = new System.Drawing.Point(31, 23);
            this.coverPhotoPictureBox.Name = "coverPhotoPictureBox";
            this.coverPhotoPictureBox.Size = new System.Drawing.Size(1121, 262);
            this.coverPhotoPictureBox.TabIndex = 1;
            this.coverPhotoPictureBox.TabStop = false;
            // 
            // listBoxNotifications
            // 
            this.listBoxNotifications.FormattingEnabled = true;
            this.listBoxNotifications.ItemHeight = 20;
            this.listBoxNotifications.Location = new System.Drawing.Point(963, 34);
            this.listBoxNotifications.Name = "listBoxNotifications";
            this.listBoxNotifications.Size = new System.Drawing.Size(184, 244);
            this.listBoxNotifications.TabIndex = 2;
            this.listBoxNotifications.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxUserInfo
            // 
            this.listBoxUserInfo.FormattingEnabled = true;
            this.listBoxUserInfo.ItemHeight = 20;
            this.listBoxUserInfo.Location = new System.Drawing.Point(31, 299);
            this.listBoxUserInfo.Name = "listBoxUserInfo";
            this.listBoxUserInfo.Size = new System.Drawing.Size(1121, 164);
            this.listBoxUserInfo.TabIndex = 3;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(31, 473);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(218, 264);
            this.listBoxFriends.TabIndex = 4;
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.ItemHeight = 20;
            this.listBoxNewsFeed.Location = new System.Drawing.Point(272, 473);
            this.listBoxNewsFeed.Name = "listBoxNewsFeed";
            this.listBoxNewsFeed.Size = new System.Drawing.Size(880, 144);
            this.listBoxNewsFeed.TabIndex = 5;
            // 
            // buttonGetGroups
            // 
            this.buttonGetGroups.Location = new System.Drawing.Point(272, 624);
            this.buttonGetGroups.Name = "buttonGetGroups";
            this.buttonGetGroups.Size = new System.Drawing.Size(160, 80);
            this.buttonGetGroups.TabIndex = 6;
            this.buttonGetGroups.Text = "Show Groups";
            this.buttonGetGroups.UseVisualStyleBackColor = true;
            this.buttonGetGroups.Click += new System.EventHandler(this.buttonGetGroups_Clicked);
            // 
            // buttonGetAlbums
            // 
            this.buttonGetAlbums.Location = new System.Drawing.Point(452, 624);
            this.buttonGetAlbums.Name = "buttonGetAlbums";
            this.buttonGetAlbums.Size = new System.Drawing.Size(160, 80);
            this.buttonGetAlbums.TabIndex = 7;
            this.buttonGetAlbums.Text = "Show Albums";
            this.buttonGetAlbums.UseVisualStyleBackColor = true;
            this.buttonGetAlbums.Click += new System.EventHandler(this.buttonGetAlbums_Clicked);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Location = new System.Drawing.Point(632, 624);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(160, 80);
            this.buttonLikedPages.TabIndex = 8;
            this.buttonLikedPages.Text = "Show Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = true;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonGetPages_Clicked);
            // 
            // labelFullName
            // 
            this.labelFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFullName.Location = new System.Drawing.Point(213, 231);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(330, 44);
            this.labelFullName.TabIndex = 9;
            // 
            // checkBoxKeepLoggedIn
            // 
            this.checkBoxKeepLoggedIn.Location = new System.Drawing.Point(271, 705);
            this.checkBoxKeepLoggedIn.Name = "checkBoxKeepLoggedIn";
            this.checkBoxKeepLoggedIn.Size = new System.Drawing.Size(184, 33);
            this.checkBoxKeepLoggedIn.TabIndex = 10;
            this.checkBoxKeepLoggedIn.Text = "Keep Me Logged In";
            this.checkBoxKeepLoggedIn.UseVisualStyleBackColor = true;
            // 
            // buttonShowEvents
            // 
            this.buttonShowEvents.Location = new System.Drawing.Point(812, 624);
            this.buttonShowEvents.Name = "buttonShowEvents";
            this.buttonShowEvents.Size = new System.Drawing.Size(160, 80);
            this.buttonShowEvents.TabIndex = 11;
            this.buttonShowEvents.Text = "Show Events";
            this.buttonShowEvents.UseVisualStyleBackColor = true;
            this.buttonShowEvents.Click += new System.EventHandler(this.buttonGetEvents_Clicked);
            // 
            // buttonShowBirthdays
            // 
            this.buttonShowBirthdays.Location = new System.Drawing.Point(992, 623);
            this.buttonShowBirthdays.Name = "buttonShowBirthdays";
            this.buttonShowBirthdays.Size = new System.Drawing.Size(160, 80);
            this.buttonShowBirthdays.TabIndex = 12;
            this.buttonShowBirthdays.Text = "Show Closest Birthdays";
            this.buttonShowBirthdays.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 768);
            this.Controls.Add(this.buttonShowBirthdays);
            this.Controls.Add(this.buttonShowEvents);
            this.Controls.Add(this.checkBoxKeepLoggedIn);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.buttonLikedPages);
            this.Controls.Add(this.buttonGetAlbums);
            this.Controls.Add(this.buttonGetGroups);
            this.Controls.Add(this.listBoxNewsFeed);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.listBoxUserInfo);
            this.Controls.Add(this.listBoxNotifications);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.coverPhotoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox coverPhotoPictureBox;
        private System.Windows.Forms.ListBox listBoxNotifications;
        private System.Windows.Forms.ListBox listBoxUserInfo;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxNewsFeed;
        private System.Windows.Forms.Button buttonGetGroups;
        private System.Windows.Forms.Button buttonGetAlbums;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.CheckBox checkBoxKeepLoggedIn;
        private System.Windows.Forms.Button buttonShowEvents;
        private System.Windows.Forms.Button buttonShowBirthdays;
    }
}