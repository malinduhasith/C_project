using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace C_2sem_Project
{
    public partial class MrRxncor : Form
    {


        public MrRxncor()
        {
            InitializeComponent();
            this.FormClosed +=
                new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
           

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            img_select.Location = new Point(b.Location.X + 112, b.Location.Y - 9);
            img_select.SendToBack();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void img_select_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
                show_page1.Show();
                input_page.Hide();
                del_page1.Hide();
                edit_page1.Hide();

      
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pro_name_def_Click(object sender, EventArgs e)
        {

        }

        private void Tab_input_Click(object sender, EventArgs e)
        {
            if (global_var.glob_user_p == "Viwer     ")
            {
                MessageBox.Show("you dont have access");
            }
            else
            {
                show_page1.Hide();
                input_page.Show();
                del_page1.Hide();
                edit_page1.Hide();
                
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tab_Edit_Click(object sender, EventArgs e)
        {
            string v = "Viwer     ";
            string getv= global_var.glob_user_p;

            if (getv.Equals(v))
            {
                MessageBox.Show("you dont have access");
            }
            else
            {
                input_page.Hide();
                edit_page1.Show();
                show_page1.Hide();
                del_page1.Hide();
            }
        }

        private void Tab_Del_Click(object sender, EventArgs e)
        {
            string v = "Viwer     ";
            string E = "Editor    ";
            string getv = global_var.glob_user_p;
            if (getv.Equals(v)|| getv.Equals(E))
            {
                MessageBox.Show("you dont have access");
            }
            else
            {
                MessageBox.Show(global_var.glob_user_p);
                del_page1.Show();
                input_page.Hide();
                edit_page1.Hide();
                show_page1.Hide();
            }
        }

        private void pro_name_def1_Click(object sender, EventArgs e)
        {

        }

        private void input_page1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            (new log_in()).close(); this.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            (new log_in()).Show(); this.Hide();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void login_display1_Load(object sender, EventArgs e)
        {

        }

        private void MrRxncor_Load(object sender, EventArgs e)
        {
            login_display1.Username= global_var.glob_user_N;
            login_display1.U_post= global_var.glob_user_p;

        }

        private void show_page1_Load(object sender, EventArgs e)
        {

        }
    }
}
