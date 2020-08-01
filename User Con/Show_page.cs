using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C_2sem_Project.User_Con
{
    public partial class Show_page : UserControl
    {
        public Show_page()
        {
            InitializeComponent();
        
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\mrrxn\Documents\Data_base\New Text Document.mdf';Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    string Name = txt_name_sh.Text;
                    string qury = "SELECT * FROM U_input WHERE U_Name ='" + Name + "'";
                    SqlCommand cmd = new SqlCommand(qury, con);
                    con.Open();
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        txt_Sp_index.Text = (read["U_Index"].ToString());
                        txt_Sp_name.Text = (read["U_Name"].ToString());
                        txt_Sp_email.Text = (read["U_Email"].ToString());
                        txt_Sp_contact.Text = (read["U_Con"].ToString());
                        txt_Sp_address.Text = (read["U_Add"].ToString());
                        SP_txt_bday.Text = (read["U_Bday"].ToString());
                    }
                    MessageBox.Show("YOU fing did it");
                }
                catch (System.IndexOutOfRangeException exc)
                {
                    MessageBox.Show("YOU SUCK" + exc);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("YOU SUCK" + ex);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
