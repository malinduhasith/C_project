using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C_2sem_Project.User_Con
{
    public partial class input_page : UserControl
    {
        public input_page()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_INp_sub_Click(object sender, EventArgs e)
        {
            //do all
            string U_name = txt_IN_name.Text;
            string U_email = txt_IN_email.Text;
            string U_con = txt_IN_email.Text;
            string U_add = txt_IN_address.Text;
            string U_bday = txt_IN_bday.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\mrrxn\Documents\Data_base\New Text Document.mdf';Integrated Security=True;Connect Timeout=30");
            string Query = "insert into U_input Values ('" + U_name + "','" + U_email + "','" + U_con + "','" + U_add + "','" + U_bday + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("YOU fing did it");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
