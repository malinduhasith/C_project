using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C_2sem_Project.User_Con
{
    public partial class edit_page : UserControl
    {
        public void edit(string Query)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\mrrxn\Documents\Data_base\New Text Document.mdf';Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand(Query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
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
        public edit_page()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string In_index = txt_EDp_index.Text;
            if (!(txt_EDp_name.Text == ""))
            {
                string Up_name = txt_EDp_name.Text;
                string Name = "UPDATE U_input SET U_name='" + Up_name + "' WHERE U_Index='" + In_index + "'";
                edit(Name);
            }
            if (!(txt_EDp_email.Text == ""))
            {
                string Up_name = txt_EDp_email.Text;
                string email = "UPDATE U_input SET U_Email='" + Up_name + "' WHERE U_Index='" + In_index + "'";
                edit(email);
            }
            if (!(txt_EDp_contact.Text == ""))
            {
                string Up_name = txt_EDp_contact.Text;
                string contact = "UPDATE U_input SET U_Con='" + Up_name + "' WHERE U_Index='" + In_index + "'";
                edit(contact);
            }
            if (!(txt_EDp_address.Text == ""))
            {
                string Up_name = txt_EDp_address.Text;
                string address = "UPDATE U_input SET U_Add='" + Up_name + "' WHERE U_Index='" + In_index + "'";
                edit(address);
            }
            if (!(txt_EDp_bday.Text == ""))
            {
                string Up_name = txt_EDp_bday.Text;
                string bday = "UPDATE U_input SET U_Bday='" + Up_name + "' WHERE U_Index='" + In_index + "'";
                edit(bday);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
