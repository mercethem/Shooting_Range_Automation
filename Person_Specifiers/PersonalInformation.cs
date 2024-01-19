using PoligonOtomasyonu;
using PoligonOtomasyonu.DataBase;
using PoligonOtomasyonu.Initializer_And_Methods;
using System.Data.SqlClient;

namespace WinFormsApp
{

    public partial class PersonInformation : Form
    {
        public string citizenId;

        public PersonInformation()
        {
            InitializeComponent();

        }
        SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
        Member member = new Member();

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void PersonInformation_Load(object sender, EventArgs e)
        {
            Ilekle();
            MemberBoardForm memberBoardForm = new MemberBoardForm();
            memberBoardForm.citizenId = citizenId;

            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();

            SqlCommand command = new SqlCommand("select * from personalInformation, contactInformation where personalInformation.citizenId= '" + citizenId.Trim() + "' AND contactInformation.citizenId = '" + citizenId.Trim() + "'", connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                member.CitizenId = citizenId;
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

            connection.Close();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            countyComboBox.Items.Clear();
            countyComboBox.Text = "";
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


        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_county_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_city_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string citizenId = this.citizenId;
            connection.Open();
            SqlCommand command = new SqlCommand(
                "IF ( '" + citizenIdTextBox.Text.Trim() + "' =(SELECT citizenId FROM personalInformation WHERE citizenId = '".Trim() + citizenIdTextBox.Text.Trim() + "') )".Trim() +
                         "    UPDATE personalInformation SET citizenId = '".Trim() + citizenIdTextBox.Text.Trim() + "', name = '".Trim() + nameTextBox.Text.Trim() + "', ".Trim() +
                         " midname = '".Trim() + midnameTextBox.Text.Trim() + "',  surname = '".Trim() + surnameTextBox.Text.Trim() + "',  gender = '".Trim() + genderComboBox.Text.Trim() + "',".Trim() +
                         "  birthdate = '".Trim() + birthdateDateTimePicker.Value.ToString("yyyy-MM-dd") + "',  bloodGroup = '".Trim() + bloodGroupComboBox.Text.Trim() + "' ".Trim() +
                         "WHERE citizenId= '".Trim() + citizenIdTextBox.Text.Trim() + "'".Trim() +
                " ELSE INSERT INTO personalInformation (citizenId, name, midname, surname, gender, birthdate, bloodGroup) ".Trim() +
                    "values('".Trim() + citizenIdTextBox.Text.Trim() + "','".Trim() + nameTextBox.Text.Trim() + "','".Trim() + midnameTextBox.Text.Trim() + "','".Trim() + surnameTextBox.Text.Trim() + "',".Trim() +
                "'".Trim() + genderComboBox.Text.Trim() + "','".Trim() + birthdateDateTimePicker.Value.ToString("yyyy-MM-dd") + "','".Trim() + bloodGroupComboBox.Text.Trim() + "') ".Trim(), connection);

            command.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand command2 = new SqlCommand("IF ('" + citizenId.Trim() + "' =(SELECT citizenId FROM contactInformation WHERE citizenId = '".Trim() + citizenId.Trim() + "') ) UPDATE contactInformation SET citizenId = '".Trim() + citizenIdTextBox.Text.Trim() + "', country = '" + countryTextBox.Text.Trim() + "', city = '".Trim() + cityComboBox.Text.Trim() + "', county = '".Trim() + countyComboBox.Text.Trim() + "', address = '".Trim() + addressTextBox.Text.Trim() + "', phone = '" + phoneNumberTextBox.Text.Trim() + "', email = '".Trim() + emailTextBox.Text.Trim() + "' WHERE contactInformation.citizenId = '".Trim() + citizenIdTextBox.Text.Trim() + "' ELSE INSERT INTO contactInformation(citizenId, country, city, county, address, phone, email) values('".Trim() + citizenIdTextBox.Text.Trim() + "', '".Trim() + countryTextBox.Text.Trim() + "', '".Trim() + cityComboBox.Text.Trim() + "', '".Trim() + countyComboBox.Text.Trim() + "', '".Trim() + addressTextBox.Text.Trim() + "', '".Trim() + phoneNumberTextBox.Text.Trim() + "', '" + emailTextBox.Text.Trim() + "')".Trim(), connection);
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
                textBoxAgeControl.BackColor = Color.Red;
            }
            else
            {
                labelUnderageAllert.Visible = false;
                textBoxAgeControl.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void criminalControlButton_Click(object sender, EventArgs e)
        {
        }
    }
}
