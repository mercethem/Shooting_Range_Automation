using System.Data.SqlClient;
using PoligonOtomasyonu.DataBase;

namespace PoligonOtomasyonu
{
    public partial class LoginMember : Form
    {
        public LoginMember()
        {
            InitializeComponent();
        }
        private void LoginMember_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DatabaseConnection.DatabaseUrl());
            string id = textIdBox.Text.Trim();
            string password = textPasswordBox.Text.Trim();
            bool isPasswordValid = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from login where citizenId = '" + id.Trim() + "' and password = '".Trim() + password.Trim() + "' and isMember = 'True'  ".Trim(), conn);
            SqlDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                if (id == d["citizenId"].ToString().Trim() && password == d["password"].ToString().Trim())
                {
                    isPasswordValid = true;
                }
            }
            d.Close();
            conn.Close();
            if (isPasswordValid == true)
            {
                MemberBoardForm memberBoardForm = new MemberBoardForm();
                memberBoardForm.citizenId = textIdBox.Text.Trim();
                memberBoardForm.ShowDialog();
                textIdBox.Clear();
                textPasswordBox.Clear();
            }
            else
            {
                MessageBox.Show("The id or password is incorrect, try again.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textIdBox_Enter(object sender, EventArgs e)
        {
            if (textIdBox.Text == "Citizen ID")
            {
                textIdBox.Text = "";
                textIdBox.ForeColor = Color.Black;
            }
        }

        private void textIdBox_Leave(object sender, EventArgs e)
        {
            if (textIdBox.Text == "")
            {
                textIdBox.Text = "Citizen ID";
                textIdBox.ForeColor = Color.Silver;
            }
        }

        private void textPasswordBox_Enter(object sender, EventArgs e)
        {
            if (textPasswordBox.Text == "Password")
            {
                textPasswordBox.Text = "";
                textPasswordBox.ForeColor = Color.Black;
            }
        }

        private void textPasswordBox_Leave(object sender, EventArgs e)
        {
            if (textPasswordBox.Text == "")
            {
                textPasswordBox.Text = "Password";
                textPasswordBox.ForeColor = Color.Silver;
            }
        }
    }
}
