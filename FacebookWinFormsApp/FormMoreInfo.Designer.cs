
namespace BasicFacebookFeatures
{
    partial class FormMoreInfo
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
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.listBoxLastPost = new System.Windows.Forms.ListBox();
            this.listBoxLastPostDate = new System.Windows.Forms.ListBox();
            this.listBoxLastPostAuthor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxName
            // 
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.ItemHeight = 20;
            this.listBoxName.Location = new System.Drawing.Point(12, 64);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(223, 344);
            this.listBoxName.TabIndex = 0;
            // 
            // listBoxLastPost
            // 
            this.listBoxLastPost.FormattingEnabled = true;
            this.listBoxLastPost.ItemHeight = 20;
            this.listBoxLastPost.Location = new System.Drawing.Point(681, 64);
            this.listBoxLastPost.Name = "listBoxLastPost";
            this.listBoxLastPost.Size = new System.Drawing.Size(742, 344);
            this.listBoxLastPost.TabIndex = 1;
            // 
            // listBoxLastPostDate
            // 
            this.listBoxLastPostDate.FormattingEnabled = true;
            this.listBoxLastPostDate.ItemHeight = 20;
            this.listBoxLastPostDate.Location = new System.Drawing.Point(464, 64);
            this.listBoxLastPostDate.Name = "listBoxLastPostDate";
            this.listBoxLastPostDate.Size = new System.Drawing.Size(187, 344);
            this.listBoxLastPostDate.TabIndex = 2;
            // 
            // listBoxLastPostAuthor
            // 
            this.listBoxLastPostAuthor.FormattingEnabled = true;
            this.listBoxLastPostAuthor.ItemHeight = 20;
            this.listBoxLastPostAuthor.Location = new System.Drawing.Point(261, 64);
            this.listBoxLastPostAuthor.Name = "listBoxLastPostAuthor";
            this.listBoxLastPostAuthor.Size = new System.Drawing.Size(187, 344);
            this.listBoxLastPostAuthor.TabIndex = 3;
            // 
            // FormMoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 427);
            this.Controls.Add(this.listBoxLastPostAuthor);
            this.Controls.Add(this.listBoxLastPostDate);
            this.Controls.Add(this.listBoxLastPost);
            this.Controls.Add(this.listBoxName);
            this.Name = "FormMoreInfo";
            this.Text = "FormGroups";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.ListBox listBoxLastPost;
        private System.Windows.Forms.ListBox listBoxLastPostDate;
        private System.Windows.Forms.ListBox listBoxLastPostAuthor;
    }
}