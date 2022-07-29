using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "1225204811548586";

        private User m_LoggedInUser;

        public FormMain(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fetchUserInfo();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FacebookService.LogoutWithUI();
            // buttonLogin.Text = "Login";
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            makeProfilePictureCircle();
        }

        private void makeProfilePictureCircle()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxProfile.Width, pictureBoxProfile.Height);
            Region rg = new Region(gp);
            pictureBoxProfile.Region = rg;
        }
    }
}
