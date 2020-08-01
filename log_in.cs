using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Management;

namespace C_2sem_Project
{
   
    public partial class log_in : Form
    {
        

        public log_in()
        {
            InitializeComponent();
            this.FormClosed +=
          new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            reg1.Hide();
            
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new MrRxncor()).Show();

        }
        public void close()
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_IN_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\mrrxn\Documents\Data_base\New Text Document.mdf';Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    
                    string User_n="", User_p="",U_pw = null;
                    string U_email = txt_log_email.Text;
                    string qury = "SELECT * FROM U_edit WHERE Uo_emali ='" + U_email + "'";
                    SqlCommand  cmda= new SqlCommand(qury, con);
                    con.Open();
                    SqlDataReader read = cmda.ExecuteReader();
                    while (read.Read())
                    {
                        U_pw = (read["Uo_pw"].ToString());
                        User_n = (read["Uo_name"].ToString());
                        User_p = (read["Uo_post"].ToString());
                    }
                    if (txt_log_pw.Text == U_pw)
                    {
                        global_var.glob_user_N = User_n;
                        global_var.glob_user_p = User_p;
                        (new MrRxncor()).Show(); this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                catch (System.IndexOutOfRangeException exc)
                {
                    MessageBox.Show("YOU SUCK" + exc);
                }
                catch (SqlException )
                {
                    MessageBox.Show("YOU SUCK");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void reg1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            reg1.Show();
        }

        private void reg1_Load_1(object sender, EventArgs e)
        {

        }
        
    }
}
