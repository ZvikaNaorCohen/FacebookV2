
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.userDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coverPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
            this.buttonGetGroups = new System.Windows.Forms.Button();
            this.buttonGetAlbums = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.userInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxKeepLoggedIn = new System.Windows.Forms.CheckBox();
            this.buttonShowBirthdays = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelHometown = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelRelationship = new System.Windows.Forms.Label();
            this.labelHobbies = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelNews = new System.Windows.Forms.Label();
            this.tableLayoutPanelFriends = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBoxProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userDataBindingSource, "ProfilePicture", true));
            this.pictureBoxProfile.Location = new System.Drawing.Point(28, 185);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(129, 94);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // userDataBindingSource
            // 
            this.userDataBindingSource.DataSource = typeof(FacebookEngine.UserData);
            // 
            // coverPhotoPictureBox
            // 
            this.coverPhotoPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.coverPhotoPictureBox.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.dummycoverphoto;
            this.coverPhotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverPhotoPictureBox.Location = new System.Drawing.Point(28, 18);
            this.coverPhotoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coverPhotoPictureBox.Name = "coverPhotoPictureBox";
            this.coverPhotoPictureBox.Size = new System.Drawing.Size(1014, 210);
            this.coverPhotoPictureBox.TabIndex = 1;
            this.coverPhotoPictureBox.TabStop = false;
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.ItemHeight = 16;
            this.listBoxNewsFeed.Location = new System.Drawing.Point(242, 438);
            this.listBoxNewsFeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxNewsFeed.Name = "listBoxNewsFeed";
            this.listBoxNewsFeed.Size = new System.Drawing.Size(800, 116);
            this.listBoxNewsFeed.TabIndex = 5;
            // 
            // buttonGetGroups
            // 
            this.buttonGetGroups.Location = new System.Drawing.Point(400, 586);
            this.buttonGetGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGetGroups.Name = "buttonGetGroups";
            this.buttonGetGroups.Size = new System.Drawing.Size(142, 64);
            this.buttonGetGroups.TabIndex = 6;
            this.buttonGetGroups.Tag = "Groups";
            this.buttonGetGroups.Text = "Show Groups";
            this.buttonGetGroups.UseVisualStyleBackColor = true;
            this.buttonGetGroups.Click += new System.EventHandler(this.buttonFacebookForm_Clicked);
            // 
            // buttonGetAlbums
            // 
            this.buttonGetAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGetAlbums.Location = new System.Drawing.Point(252, 586);
            this.buttonGetAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGetAlbums.Name = "buttonGetAlbums";
            this.buttonGetAlbums.Size = new System.Drawing.Size(142, 64);
            this.buttonGetAlbums.TabIndex = 7;
            this.buttonGetAlbums.Tag = "Albums";
            this.buttonGetAlbums.Text = "Show Albums";
            this.buttonGetAlbums.UseVisualStyleBackColor = true;
            this.buttonGetAlbums.Click += new System.EventHandler(this.buttonFacebookForm_Clicked);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Location = new System.Drawing.Point(550, 586);
            this.buttonLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(142, 64);
            this.buttonLikedPages.TabIndex = 8;
            this.buttonLikedPages.Tag = "Pages";
            this.buttonLikedPages.Text = "Show Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = true;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonFacebookForm_Clicked);
            // 
            // labelFullName
            // 
            this.labelFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInformationBindingSource, "Name", true));
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFullName.ForeColor = System.Drawing.Color.Black;
            this.labelFullName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelFullName.Location = new System.Drawing.Point(163, 239);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(379, 35);
            this.labelFullName.TabIndex = 9;
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userInformationBindingSource
            // 
            this.userInformationBindingSource.DataSource = typeof(FacebookEngine.UserInformation);
            // 
            // checkBoxKeepLoggedIn
            // 
            this.checkBoxKeepLoggedIn.Location = new System.Drawing.Point(850, 245);
            this.checkBoxKeepLoggedIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxKeepLoggedIn.Name = "checkBoxKeepLoggedIn";
            this.checkBoxKeepLoggedIn.Size = new System.Drawing.Size(174, 26);
            this.checkBoxKeepLoggedIn.TabIndex = 10;
            this.checkBoxKeepLoggedIn.Text = "Keep Me Logged In";
            this.checkBoxKeepLoggedIn.UseVisualStyleBackColor = true;
            this.checkBoxKeepLoggedIn.CheckedChanged += new System.EventHandler(this.checkBoxKeepLoggedIn_CheckedChanged);
            // 
            // buttonShowBirthdays
            // 
            this.buttonShowBirthdays.Location = new System.Drawing.Point(698, 586);
            this.buttonShowBirthdays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowBirthdays.Name = "buttonShowBirthdays";
            this.buttonShowBirthdays.Size = new System.Drawing.Size(142, 64);
            this.buttonShowBirthdays.TabIndex = 12;
            this.buttonShowBirthdays.Tag = "Birthdays";
            this.buttonShowBirthdays.Text = "Show Closest Birthdays";
            this.buttonShowBirthdays.UseVisualStyleBackColor = true;
            this.buttonShowBirthdays.Click += new System.EventHandler(this.buttonFacebookForm_Clicked);
            // 
            // labelEmail
            // 
            this.labelEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInformationBindingSource, "Email", true));
            this.labelEmail.Image = global::BasicFacebookFeatures.Properties.Resources.Email;
            this.labelEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEmail.Location = new System.Drawing.Point(25, 287);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(197, 43);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHometown
            // 
            this.labelHometown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInformationBindingSource, "Hometown", true));
            this.labelHometown.Image = global::BasicFacebookFeatures.Properties.Resources.hometown;
            this.labelHometown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelHometown.Location = new System.Drawing.Point(495, 294);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(197, 29);
            this.labelHometown.TabIndex = 14;
            this.labelHometown.Text = "Hometown";
            this.labelHometown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBirthday
            // 
            this.labelBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInformationBindingSource, "Birthday", true));
            this.labelBirthday.Image = global::BasicFacebookFeatures.Properties.Resources.Birthday;
            this.labelBirthday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBirthday.Location = new System.Drawing.Point(845, 294);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(197, 26);
            this.labelBirthday.TabIndex = 15;
            this.labelBirthday.Text = "Birthday";
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRelationship
            // 
            this.labelRelationship.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInformationBindingSource, "RelationshipStatus", true));
            this.labelRelationship.Image = global::BasicFacebookFeatures.Properties.Resources.heart;
            this.labelRelationship.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRelationship.Location = new System.Drawing.Point(25, 338);
            this.labelRelationship.Name = "labelRelationship";
            this.labelRelationship.Size = new System.Drawing.Size(197, 31);
            this.labelRelationship.TabIndex = 16;
            this.labelRelationship.Text = "Relationship";
            this.labelRelationship.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHobbies
            // 
            this.labelHobbies.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInformationBindingSource, "InterestedIn", true));
            this.labelHobbies.Image = global::BasicFacebookFeatures.Properties.Resources.Hobbies;
            this.labelHobbies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelHobbies.Location = new System.Drawing.Point(495, 338);
            this.labelHobbies.Name = "labelHobbies";
            this.labelHobbies.Size = new System.Drawing.Size(197, 30);
            this.labelHobbies.TabIndex = 17;
            this.labelHobbies.Text = "Hobbies";
            this.labelHobbies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFriends
            // 
            this.labelFriends.Image = global::BasicFacebookFeatures.Properties.Resources.friend;
            this.labelFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFriends.Location = new System.Drawing.Point(28, 400);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(194, 36);
            this.labelFriends.TabIndex = 18;
            this.labelFriends.Text = "Friends";
            this.labelFriends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNews
            // 
            this.labelNews.Image = global::BasicFacebookFeatures.Properties.Resources.news;
            this.labelNews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNews.Location = new System.Drawing.Point(242, 405);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(191, 31);
            this.labelNews.TabIndex = 19;
            this.labelNews.Text = "News feed";
            this.labelNews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelFriends
            // 
            this.tableLayoutPanelFriends.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelFriends.ColumnCount = 1;
            this.tableLayoutPanelFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFriends.Location = new System.Drawing.Point(28, 439);
            this.tableLayoutPanelFriends.Name = "tableLayoutPanelFriends";
            this.tableLayoutPanelFriends.RowCount = 2;
            this.tableLayoutPanelFriends.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFriends.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFriends.Size = new System.Drawing.Size(50, 50);
            this.tableLayoutPanelFriends.TabIndex = 20;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 691);
            this.Controls.Add(this.tableLayoutPanelFriends);
            this.Controls.Add(this.labelNews);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.labelHobbies);
            this.Controls.Add(this.labelRelationship);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelHometown);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonShowBirthdays);
            this.Controls.Add(this.checkBoxKeepLoggedIn);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.buttonLikedPages);
            this.Controls.Add(this.buttonGetAlbums);
            this.Controls.Add(this.buttonGetGroups);
            this.Controls.Add(this.listBoxNewsFeed);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.coverPhotoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Main";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox coverPhotoPictureBox;
        private System.Windows.Forms.ListBox listBoxNewsFeed;
        private System.Windows.Forms.Button buttonGetGroups;
        private System.Windows.Forms.Button buttonGetAlbums;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.CheckBox checkBoxKeepLoggedIn;
        private System.Windows.Forms.Button buttonShowBirthdays;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelRelationship;
        private System.Windows.Forms.Label labelHobbies;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelNews;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFriends;
        private System.Windows.Forms.BindingSource userInformationBindingSource;
        private System.Windows.Forms.BindingSource userDataBindingSource;
    }
}