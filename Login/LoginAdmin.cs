using System.Data.SqlClient;
using PoligonOtomasyonu.DataBase;

namespace PoligonOtomasyonu
{
    public partial class LoginAdmin : Form
    {
        public string adminLoginId;

        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DatabaseConnection.DatabaseUrl());
            string id = textIdBox.Text;
            string password = textPasswordBox.Text;
            bool isPasswordValid = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from login where citizenId = '" + id.Trim() + "' and password = '".Trim() + password.Trim() + "' and isAdmin = 'True' ".Trim(), conn);
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
                adminLoginId = textIdBox.Text.ToString().Trim();
                AdminBoardForm adminBoardForm = new AdminBoardForm();
                adminBoardForm.citizenId = adminLoginId;
                textIdBox.Clear();
                textPasswordBox.Clear();
                adminBoardForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("The id or password is incorrect, try again.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
