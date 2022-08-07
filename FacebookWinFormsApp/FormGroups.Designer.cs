
namespace BasicFacebookFeatures
{
    partial class FormGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroups));
            this.labelGroupName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.listBoxDescription = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGroupName
            // 
            this.labelGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGroupName.Location = new System.Drawing.Point(66, 8);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(73, 29);
            this.labelGroupName.TabIndex = 2;
            this.labelGroupName.Text = "Name";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescription.Location = new System.Drawing.Point(434, 8);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(146, 29);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.Location = new System.Drawing.Point(921, 39);
            this.pictureBoxGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(324, 265);
            this.pictureBoxGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroup.TabIndex = 4;
            this.pictureBoxGroup.TabStop = false;
            // 
            // listBoxName
            // 
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.ItemHeight = 16;
            this.listBoxName.Location = new System.Drawing.Point(11, 39);
            this.listBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(216, 292);
            this.listBoxName.TabIndex = 0;
            this.listBoxName.Click += new System.EventHandler(this.listBoxName_Clicked);
            // 
            // listBoxDescription
            // 
            this.listBoxDescription.FormattingEnabled = true;
            this.listBoxDescription.ItemHeight = 16;
            this.listBoxDescription.Location = new System.Drawing.Point(244, 39);
            this.listBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDescription.Name = "listBoxDescription";
            this.listBoxDescription.Size = new System.Drawing.Size(660, 292);
            this.listBoxDescription.TabIndex = 1;
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 339);
            this.Controls.Add(this.listBoxDescription);
            this.Controls.Add(this.listBoxName);
            this.Controls.Add(this.pictureBoxGroup);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelGroupName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGroups";
            this.Text = "Groups";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.PictureBox pictureBoxGroup;
        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.ListBox listBoxDescription;
    }
}