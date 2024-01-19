using System.Data.SqlClient;
using PoligonOtomasyonu.DataBase;
using PoligonOtomasyonu.Initializer_And_Methods;
using WinFormsApp;

namespace PoligonOtomasyonu
{
    public partial class MemberListPersonalInformation : Form
    {

        public MemberListPersonalInformation()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
        Member member = new Member();
        public string citizenId;
        private void MemberListPersonalInformation_Load(object sender, EventArgs e)
        {

            buttonCriminalControl.Enabled = false;
            buttonStatusSave.Enabled = false;
            birthdateDateTimePicker.MaxDate = DateTime.Now;

            Ilekle();

            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM personalInformation, contactInformation WHERE (personalInformation.citizenId = contactInformation.citizenId) AND personalInformation.citizenId = '" + citizenId + "'", connection);

            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                string status;
                member.CitizenId = citizenId = sqlDataReader[0].ToString().Trim();
                member.Name = sqlDataReader[1].ToString().Trim();
                member.MidName = sqlDataReader[2].ToString().Trim();
                member.Surname = sqlDataReader[3].ToString().Trim();
                member.Gender = sqlDataReader[4].ToString().Trim();
                member.Birthdate = Convert.ToDateTime(sqlDataReader[5]);
                member.BloodGroup = sqlDataReader[6].ToString().Trim();
                member.Country = sqlDataReader[9].ToString().Trim();
                member.City = sqlDataReader[10].ToString().Trim();
                member.County = sqlDataReader[11].ToString().Trim();
                member.Address = sqlDataReader[12].ToString().Trim();
                member.Phone = sqlDataReader[13].ToString().Trim();
                member.Email = sqlDataReader[14].ToString().Trim();
            }

            citizenIdTextBox.Text = member.CitizenId.Trim();
            nameTextBox.Text = member.Name.Trim();
            midnameTextBox.Text = member.MidName.Trim();
            surnameTextBox.Text = member.Surname.Trim();
            genderComboBox.Text = member.Gender.Trim();
            birthdateDateTimePicker.Value = Convert.ToDateTime(member.Birthdate);
            bloodGroupComboBox.Text = member.BloodGroup.Trim();
            countryTextBox.Text = member.Country.Trim();
            cityComboBox.Text = member.City.Trim();
            countyComboBox.Text = member.County.Trim();
            addressTextBox.Text = member.Address.Trim();
            phoneNumberTextBox.Text = member.Phone.Trim();
            emailTextBox.Text = member.Email.Trim();
            ageTextBox.Text = Convert.ToString(member.CalculateAge());

            sqlDataReader.Close();
            connection.Close();

            SqlCommand command2 = new SqlCommand("SELECT * FROM login where citizenId = '" + member.CitizenId.Trim().ToString() + "' ", connection);
            connection.Open();
            SqlDataReader sqlDataReader2 = command2.ExecuteReader();

            while (sqlDataReader2.Read())
            {
                if (sqlDataReader2[2].ToString().Trim() == "True")
                {
                    checkBoxIsMember.Checked = true;
                }
                if (sqlDataReader2[3].ToString().Trim() == "True")
                {
                    checkBoxIsEmployee.Checked = true;
                }
                if (sqlDataReader2[4].ToString().Trim() == "True")
                {
                    checkBoxIsAdmin.Checked = true;
                }

            }
            sqlDataReader2.Close();
            connection.Close();
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            countyComboBox.Items.Clear();
            countyComboBox.Text = "".Trim();

            connection.Open();
            SqlCommand command = new SqlCommand("select * from ilceler where sehirid=@p1", connection);
            command.Parameters.AddWithValue("@p1", cityComboBox.SelectedIndex + 1);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                countyComboBox.Items.Add(sqlDataReader[1].ToString().Trim());
            }
            sqlDataReader.Close();
            connection.Close();
        }
        void Ilekle()
        {

            connection.Open();
            SqlCommand command = new SqlCommand("select * from iller", connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cityComboBox.Items.Add(sqlDataReader[1].ToString().Trim());
            }
            sqlDataReader.Close();
            connection.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string citizenId = this.citizenId;
            connection.Open();
            SqlCommand command = new SqlCommand(
                "IF ( '" + citizenIdTextBox.Text.Trim() + "' =(SELECT citizenId FROM personalInformation WHERE citizenId = '".Trim() + citizenIdTextBox.Text.Trim() + "') )".Trim() +
                         "    UPDATE personalInformation SET citizenId = '".Trim() + citizenIdTextBox.Text.Trim() + "', name = '".Trim() + nameTextBox.Text.Trim() + "', ".Trim() +
                         " midname = '".Trim() + midnameTextBox.Text.Trim() + "',  surname = '".Trim() + surnameTextBox.Text.Trim() + "',  gender = '".Trim() + genderComboBox.Text.Trim() + "',".Trim() +
                         "  birthdate = '".Trim() + birthdateDateTimePicker.Value.ToString("yyyy-MM-dd").Trim() + "',  bloodGroup = '".Trim() + bloodGroupComboBox.Text.Trim() + "' ".Trim() +
                         "WHERE citizenId= '".Trim() + citizenIdTextBox.Text.Trim() + "'".Trim() +
                " ELSE INSERT INTO personalInformation (citizenId, name, midname, surname, gender, birthdate, bloodGroup) ".Trim() +
                    "values('".Trim() + citizenIdTextBox.Text.Trim() + "','".Trim() + nameTextBox.Text.Trim() + "','".Trim() + midnameTextBox.Text.Trim() + "','".Trim() + surnameTextBox.Text.Trim() + "',".Trim() +
                "'".Trim() + genderComboBox.Text.Trim() + "','".Trim() + birthdateDateTimePicker.Value.ToString("yyyy-MM-dd") + "','".Trim() + bloodGroupComboBox.Text.Trim() + "') ".Trim(), connection);

            command.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand command2 = new SqlCommand("IF ('" + citizenIdTextBox.Text.Trim() + "' =(SELECT citizenId FROM contactInformation WHERE citizenId = '" + citizenIdTextBox.Text.Trim() + "') ) UPDATE contactInformation SET citizenId = '".Trim() + citizenIdTextBox.Text.Trim() + "', country = '".Trim() + countryTextBox.Text.Trim() + "', city = '".Trim() + cityComboBox.Text.Trim() + "', county = '".Trim() + countyComboBox.Text.Trim() + "', address = '".Trim() + addressTextBox.Text.Trim() + "', phone = '".Trim() + phoneNumberTextBox.Text.Trim() + "', email = '".Trim() + emailTextBox.Text.Trim() + "' WHERE citizenId = '".Trim() + citizenIdTextBox.Text.Trim() + "' ELSE INSERT INTO contactInformation(citizenId, country, city, county, address, phone, email) values('".Trim() + citizenIdTextBox.Text.Trim() + "', '".Trim() + countryTextBox.Text.Trim() + "', '".Trim() + cityComboBox.Text.Trim() + "', '".Trim() + countyComboBox.Text.Trim() + "', '".Trim() + addressTextBox.Text.Trim() + "', '".Trim() + phoneNumberTextBox.Text.Trim() + "', '".Trim() + emailTextBox.Text.Trim() + "')".Trim(), connection);
            command2.ExecuteNonQuery();
            connection.Close();

            Utilities.PistolSound();
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt64(ageTextBox.Text) < 18)
            {
                textBoxAgeControl.Visible = true;
                labelUnderageAllert.Visible = true;
                textBoxAgeControl.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                labelUnderageAllert.Visible = false;
                textBoxAgeControl.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonCriminalControl_Click(object sender, EventArgs e)
        {
            string id = textBoxAdminCitizenId.Text;
            string password = textBoxAdminPassword.Text;
            bool isPasswordValid = false;
            connection.Open();
            SqlCommand command = new SqlCommand("select * from login where citizenId = '" + id.Trim() + "' and password = '".Trim() + password.Trim() + "' and isAdmin = 'True' ".Trim(), connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (id == reader["citizenId"].ToString().Trim() && password == reader["password"].ToString().Trim())
                {
                    isPasswordValid = true;
                    Utilities.CriminalControlMailSend(citizenIdTextBox.Text.Trim(), nameTextBox.Text.Trim(), surnameTextBox.Text.Trim());
                }
            }
            reader.Close();
            connection.Close();
            if (isPasswordValid == true)
            {
                MessageBox.Show("Message Send!");
            }
            else
            {
                MessageBox.Show("Access Denied!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkCriminalControl_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCriminalControl.Checked)
            {
                buttonCriminalControl.Enabled = true;
            }
            else
            {
                buttonCriminalControl.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBoxStatusSave_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStatusSave.Checked)
            {
                buttonStatusSave.Enabled = true;
            }
            else
            {
                buttonStatusSave.Enabled = false;
            }
        }

        private void buttonStatusSave_Click(object sender, EventArgs e)
        {
            string id = textBoxAdminCitizenId.Text;
            string password = textBoxAdminPassword.Text;
            bool isPasswordValid = false;
            connection.Open();

            SqlCommand command = new SqlCommand("select * from login where citizenId = '" + id.Trim() + "' and password = '" + password.Trim() + "' and isAdmin = 'True' ", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (id == reader["citizenId"].ToString().Trim() && password == reader["password"].ToString().Trim())
                {
                    isPasswordValid = true;
                }
            }

            reader.Close();
            connection.Close();

            if (isPasswordValid == true)
            {
                connection.Open();

                string isMember;
                string isEmployee;
                string isAdmin;

                isMember = checkBoxIsMember.Checked == true ? "True" : "False";
                isEmployee = checkBoxIsEmployee.Checked == true ? "True" : "False";
                isAdmin = checkBoxIsAdmin.Checked == true ? "True" : "False";

                SqlCommand command2 = new SqlCommand(
                        "UPDATE login SET isMember = '" + isMember + "', isEmployee = '" + isEmployee + "'," +
                              "isAdmin = '" + isAdmin + "' " +
                        "WHERE login.citizenId= '" + citizenIdTextBox.Text.Trim() + "' ", connection);

                command2.ExecuteNonQuery();

                MessageBox.Show("Status Changed!");
                Utilities.PistolSound();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Access Denied!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
