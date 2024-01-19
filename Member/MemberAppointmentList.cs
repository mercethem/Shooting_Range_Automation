using PoligonOtomasyonu.DataBase;
using PoligonOtomasyonu.Initializer_And_Methods;
using System.Data.SqlClient;

namespace PoligonOtomasyonu
{
    public partial class MemberAppointmentList : Form
    {
        public string citizenId;
        int appointmentId;

        public MemberAppointmentList()
        {
            InitializeComponent();
            saveButton.Enabled = false;
        }

        private void AppointmentListListView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                appointmentId = Convert.ToInt32(AppointmentListListView.SelectedItems[0].SubItems[0].Text.Trim());
                citizenId = AppointmentListListView.SelectedItems[0].SubItems[1].Text.Trim();
                appointmentCalendarTimePicker.Value = Convert.ToDateTime(AppointmentListListView.SelectedItems[0].SubItems[2].Text.Trim());
                appointmentHourComboBox.Text = AppointmentListListView.SelectedItems[0].SubItems[3].Text.Trim();
                appointmentRangeComboBox.Text = AppointmentListListView.SelectedItems[0].SubItems[4].Text.Trim();

                if (appointmentCalendarTimePicker.Value < DateTime.Now)
                {
                    saveButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Anlık tarihi değiştiremezsiniz");
            }

        }
        private void AppointmentListListView_DoubleClick()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();
            SqlCommand command = new SqlCommand(
                "UPDATE appointmentInformation SET appointmentDate = '" + appointmentCalendarTimePicker.Value.ToString("yyyy-MM-dd").Trim() + "', appointmentHour = '" + appointmentHourComboBox.Text.Trim() + "', " +
            "appointmentRange = '" + appointmentRangeComboBox.Text.Trim() + "'" +
            "WHERE appointmentId = '" + appointmentId + "' ", connection);

            command.ExecuteNonQuery();
            connection.Close();
            AppointmentListListView.Items.Clear();
            MemberAppointmentList_Load();
        }

        private void MemberAppointmentList_Load(object sender, EventArgs e)
        {
            MemberAppointmentList_Load();
        }
        private void MemberAppointmentList_Load()
        {
            string citizenId = this.citizenId;
            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM appointmentInformation WHERE citizenId = '" + citizenId.Trim() + "'ORDER BY appointmentDate DESC".Trim(), connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["appointmentId"].ToString();
                listViewItem.SubItems.Add(reader["citizenId"].ToString().Trim());
                listViewItem.SubItems.Add(reader["appointmentDate"].ToString().Trim());
                listViewItem.SubItems.Add(reader["appointmentHour"].ToString().Trim());
                listViewItem.SubItems.Add(reader["appointmentRange"].ToString().Trim());
                AppointmentListListView.Items.Add(listViewItem);
            }
            reader.Close();
            connection.Close();
        }

        private void appointmentCheckBox_CheckedChanged(object sender, EventArgs e)
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
