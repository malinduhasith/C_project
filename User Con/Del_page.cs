using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C_2sem_Project.User_Con
{
    public partial class Del_page : UserControl
    {
        public Del_page()
        {
            InitializeComponent();
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\mrrxn\Documents\Data_base\New Text Document.mdf';Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    log_in texUc = new log_in();
                    string u_pw = txt_DELp_pw.Text;
                    string u_id = txt_DELp_index.Text;
                    string user = global_var.glob_user_N;
                    string G_post = "0";
                    string qury = "SELECT * FROM U_edit WHERE Uo_name ='" + user + "'";
                    SqlCommand cmd = new SqlCommand(qury, con);
                    
                    con.Open();
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        G_post = (read["Uo_Post"].ToString());

                    }
                    MessageBox.Show("|"+G_post+"|"+"\n"+ "|Admin     |");
                    if (G_post == "Admin     ")
                    {
                        con.Close();
                        con.Open();
                        string qury_del = "DELETE FROM U_input WHERE U_Index ='" + u_id + "'";
                        SqlCommand cmd_del = new SqlCommand(qury_del, con);
                        cmd_del.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("pw error");
                    }

                    MessageBox.Show("YOU fing did it");
                }
                catch (System.IndexOutOfRangeException exc)
                {
                    MessageBox.Show("YOU SUCK index" + exc);
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
        private void txt_EDp_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
