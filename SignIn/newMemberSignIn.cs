using System.Data.SqlClient;
using System.Text.RegularExpressions;
using PoligonOtomasyonu.DataBase;
using PoligonOtomasyonu.Initializer_And_Methods;

namespace PoligonOtomasyonu
{
    public partial class newMemberSignIn : Form
    {
        public newMemberSignIn()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(citizenIdTextBox.Text.Trim(), @"^[0-9]+$"))
            {
                SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
                connection.Open();
                bool isMember = false;

                SqlCommand cmd = new SqlCommand("SELECT citizenId FROM login WHERE citizenId = '" + citizenIdTextBox.Text.Trim() + "' ", connection);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    if (citizenIdTextBox.Text.Trim() == read[0].ToString().Trim())
                    {
                        isMember = true;
                    }
                }
                read.Close();
                connection.Close();

                if (isMember == true)
                {
                    MessageBox.Show("Zaten Kayıtlısınız!.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    connection.Open();
                    SqlCommand commandAddEquipment = new SqlCommand("INSERT INTO login (citizenId, password, isMember) VALUES ('" + citizenIdTextBox.Text.Trim() + "', '" + passwordTextBox.Text.Trim() + "', 'True')" +
                        "INSERT INTO personalInformation (citizenId) VALUES ('" + citizenIdTextBox.Text.Trim() + "')" +
                        "INSERT INTO contactInformation (citizenId) VALUES ('" + citizenIdTextBox.Text.Trim() + "')", connection);
                    commandAddEquipment.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Kayıt Oldunuz.", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Utilities.PistolSound();
                }
            }
            else
            {
                MessageBox.Show("The id is incorrect, try again.", "Invalid Citizen Id!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
