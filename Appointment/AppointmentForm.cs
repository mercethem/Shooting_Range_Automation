using PoligonOtomasyonu.DataBase;
using PoligonOtomasyonu.Initializer_And_Methods;
using System.Data.SqlClient;

namespace WinFormsApp
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
            saveButton.Enabled = false;
            appointmentCalendarTimePicker.MinDate = DateTime.Now;
        }
        public string citizenId;

        private void Appointment_Form_Load(object sender, EventArgs e)
        {
        }

        private void AppointmentHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilities.ReloadSound();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO appointmentInformation (citizenId, appointmentDate, appointmentHour, appointmentRange)" +
                "VALUES('" + citizenId.ToString() + "','" + appointmentCalendarTimePicker.Value.ToString("yyyy-MM-dd").Trim() + "','" + appointmentHourComboBox.Text.Trim() + "','" + appointmentRangeComboBox.Text.Trim() + "')", connection);


            SqlCommand command2 = new SqlCommand("IF  ('" + citizenId.ToString() + "' = (SELECT citizenId FROM appointmentInformation WHERE citizenId = '" + citizenId.ToString() + "')" +
                "AND '" + appointmentCalendarTimePicker.Value.ToString("yyyy-MM-dd").Trim() + "' = (SELECT appointmentDate FROM appointmentInformation WHERE appointmentDate = '" + appointmentCalendarTimePicker.Value.ToString("yyyy-MM-dd").Trim() + "')" +
                "AND '" + appointmentHourComboBox.Text.Trim() + "' = (SELECT appointmentHour FROM appointmentInformation WHERE appointmentHour = '" + appointmentHourComboBox.Text.Trim() + "')" +
                "AND '" + appointmentRangeComboBox.Text.Trim() + "' = (SELECT appointmentRange FROM appointmentInformation WHERE appointmentRange = '" + appointmentRangeComboBox.Text.Trim() + "'))" +
                "UPDATE appointmentInformation SET appointmentDate = '" + appointmentCalendarTimePicker.Value.ToString("yyyy-MM-dd").Trim() + "',  appointmentHour = '" + appointmentHourComboBox.Text.Trim() + "'," +
                "appointmentRange = '" + appointmentRangeComboBox.Text.Trim() + "'" +
                "WHERE citizenId = '" + citizenId.ToString() + "' AND  appointmentDate = '" + appointmentCalendarTimePicker.Value.ToString("yyyy-MM-dd").Trim() + "' AND appointmentHour = '" + appointmentHourComboBox.Text.Trim() + "' AND appointmentRange = '" + appointmentRangeComboBox.Text.Trim() + "'" +
                "ELSE " +
                "INSERT INTO appointmentInformation (citizenId, appointmentDate, appointmentHour, appointmentRange)" +
                "VALUES('" + citizenId.ToString() + "','" + appointmentCalendarTimePicker.Value.ToString("yyyy-MM-dd").Trim() + "','" + appointmentHourComboBox.Text.Trim() + "','" + appointmentRangeComboBox.Text.Trim() + "')", connection);

            command.ExecuteNonQuery();
            connection.Close();
            Utilities.PistolSound();
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (appointmentCheckBox.Checked)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
            Utilities.ReloadSound2();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
