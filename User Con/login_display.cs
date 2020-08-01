using System;
using System.Drawing;
using System.Windows.Forms;

namespace C_2sem_Project.User_Con
{
    public partial class login_display : UserControl
    {
        public login_display()
        {
            InitializeComponent();
        }

        private void login_display_Load(object sender, EventArgs e)
        {
        }
        public string Username
        {
            get { return lbl_LD_Name.Text; }
            set { lbl_LD_Name.Text = value; }
        }
        public string U_post
        {
            get { return lbl_LD_Post.Text; }
            set { lbl_LD_Post.Text = value; }
        }
        public Image p_pic
        {
            get { return img_LD_profile.Image; }
            set { img_LD_profile.Image = value; }
        }
    }
}
