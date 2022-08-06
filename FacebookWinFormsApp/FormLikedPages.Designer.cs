
namespace BasicFacebookFeatures
{
    partial class FormLikedPages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLikedPages));
            this.listBoxPageName = new System.Windows.Forms.ListBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPageName
            // 
            this.listBoxPageName.FormattingEnabled = true;
            this.listBoxPageName.ItemHeight = 20;
            this.listBoxPageName.Location = new System.Drawing.Point(12, 15);
            this.listBoxPageName.Name = "listBoxPageName";
            this.listBoxPageName.Size = new System.Drawing.Size(300, 404);
            this.listBoxPageName.TabIndex = 0;
            this.listBoxPageName.Click += new System.EventHandler(this.listBoxPage_Clicked);
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.Location = new System.Drawing.Point(340, 66);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(289, 312);
            this.pictureBoxPage.TabIndex = 1;
            this.pictureBoxPage.TabStop = false;
            // 
            // FormLikedPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 426);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.listBoxPageName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLikedPages";
            this.Text = "Liked Pages";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPageName;
        private System.Windows.Forms.PictureBox pictureBoxPage;
    }
}