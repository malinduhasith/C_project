using System.Windows.Forms;
using System.Data.SqlClient;

namespace C_2sem_Project.User_Con
{
    public partial class reg : UserControl
    {
        public reg()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, System.EventArgs e)
        {
            string U_name = REG_name.Text;
            string U_email = REG_name.Text;
            string U_con = REG_pw.Text;
            string U_p = "null";
            if (R_ad.Checked == true)
            {
                U_p = "Admin";
            }else if(R_ed.Checked == true)
            {
                U_p = "Editor";
            }else if(R_vi.Checked == true)
            {
                U_p = "Viwer";
            }
            else if(U_p == "null")
            {
                //error
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\mrrxn\Documents\Data_base\New Text Document.mdf';Integrated Security=True;Connect Timeout=30");
            string Query = "insert into U_edit Values ('" + U_name + "','" + U_email + "','" + U_con + "','" + U_p + "')";
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

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void reg_Load(object sender, System.EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
