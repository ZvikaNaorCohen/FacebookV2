
namespace BasicFacebookFeatures
{
    partial class FormBirthdays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBirthdays));
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.groupBoxSortBy = new System.Windows.Forms.GroupBox();
            this.radioButtonDaysToBirthday = new System.Windows.Forms.RadioButton();
            this.radioButtonAges = new System.Windows.Forms.RadioButton();
            this.radioButtonAToZ = new System.Windows.Forms.RadioButton();
            this.buttonPostWish = new System.Windows.Forms.Button();
            this.groupBoxSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxName
            // 
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.ItemHeight = 20;
            this.listBoxName.Location = new System.Drawing.Point(12, 25);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(482, 344);
            this.listBoxName.TabIndex = 0;
            this.listBoxName.Click += new System.EventHandler(this.listBoxName_Click);
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSortBy.Location = new System.Drawing.Point(12, 381);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(94, 29);
            this.labelSortBy.TabIndex = 1;
            this.labelSortBy.Text = "Sort by:";
            // 
            // groupBoxSortBy
            // 
            this.groupBoxSortBy.Controls.Add(this.radioButtonDaysToBirthday);
            this.groupBoxSortBy.Controls.Add(this.radioButtonAges);
            this.groupBoxSortBy.Controls.Add(this.radioButtonAToZ);
            this.groupBoxSortBy.Location = new System.Drawing.Point(112, 371);
            this.groupBoxSortBy.Name = "groupBoxSortBy";
            this.groupBoxSortBy.Size = new System.Drawing.Size(175, 107);
            this.groupBoxSortBy.TabIndex = 2;
            this.groupBoxSortBy.TabStop = false;
            // 
            // radioButtonDaysToBirthday
            // 
            this.radioButtonDaysToBirthday.AutoSize = true;
            this.radioButtonDaysToBirthday.Location = new System.Drawing.Point(7, 74);
            this.radioButtonDaysToBirthday.Name = "radioButtonDaysToBirthday";
            this.radioButtonDaysToBirthday.Size = new System.Drawing.Size(154, 24);
            this.radioButtonDaysToBirthday.TabIndex = 2;
            this.radioButtonDaysToBirthday.TabStop = true;
            this.radioButtonDaysToBirthday.Text = "Days To Birthday";
            this.radioButtonDaysToBirthday.UseVisualStyleBackColor = true;
            this.radioButtonDaysToBirthday.Click += new System.EventHandler(this.radioButtonDaysToBirthday_Clicked);
            // 
            // radioButtonAges
            // 
            this.radioButtonAges.AutoSize = true;
            this.radioButtonAges.Location = new System.Drawing.Point(7, 44);
            this.radioButtonAges.Name = "radioButtonAges";
            this.radioButtonAges.Size = new System.Drawing.Size(71, 24);
            this.radioButtonAges.TabIndex = 1;
            this.radioButtonAges.TabStop = true;
            this.radioButtonAges.Text = "Ages";
            this.radioButtonAges.UseVisualStyleBackColor = true;
            this.radioButtonAges.Click += new System.EventHandler(this.radioButtonAges_Clicked);
            // 
            // radioButtonAToZ
            // 
            this.radioButtonAToZ.AutoSize = true;
            this.radioButtonAToZ.Location = new System.Drawing.Point(7, 14);
            this.radioButtonAToZ.Name = "radioButtonAToZ";
            this.radioButtonAToZ.Size = new System.Drawing.Size(60, 24);
            this.radioButtonAToZ.TabIndex = 0;
            this.radioButtonAToZ.TabStop = true;
            this.radioButtonAToZ.Text = "A-Z";
            this.radioButtonAToZ.UseVisualStyleBackColor = true;
            this.radioButtonAToZ.Click += new System.EventHandler(this.radioButtonAToZ_Clicked);
            // 
            // buttonPostWish
            // 
            this.buttonPostWish.Enabled = false;
            this.buttonPostWish.Location = new System.Drawing.Point(293, 381);
            this.buttonPostWish.Name = "buttonPostWish";
            this.buttonPostWish.Size = new System.Drawing.Size(201, 97);
            this.buttonPostWish.TabIndex = 3;
            this.buttonPostWish.Text = "POST WISH ON FRIEND\'S BIRTHDAY";
            this.buttonPostWish.UseVisualStyleBackColor = true;
            // 
            // FormBirthdays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 483);
            this.Controls.Add(this.buttonPostWish);
            this.Controls.Add(this.groupBoxSortBy);
            this.Controls.Add(this.labelSortBy);
            this.Controls.Add(this.listBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBirthdays";
            this.Text = "Birthdays";
            this.groupBoxSortBy.ResumeLayout(false);
            this.groupBoxSortBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.GroupBox groupBoxSortBy;
        private System.Windows.Forms.RadioButton radioButtonDaysToBirthday;
        private System.Windows.Forms.RadioButton radioButtonAges;
        private System.Windows.Forms.RadioButton radioButtonAToZ;
        private System.Windows.Forms.Button buttonPostWish;
    }
}