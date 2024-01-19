using PoligonOtomasyonu.DataBase;

using System.Data.SqlClient;

namespace WinFormsApp
{
    public partial class AppointmentList : Form
    {
        public AppointmentList()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM appointmentInformation ORDER BY appointmentDate DESC", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["citizenId"].ToString().Trim();
                listViewItem.SubItems.Add(reader["appointmentDate"].ToString().Trim());
                listViewItem.SubItems.Add(reader["appointmentHour"].ToString().Trim());
                listViewItem.SubItems.Add(reader["appointmentRange"].ToString().Trim());
                AppointmentListListView.Items.Add(listViewItem);
            }
            reader.Close();
            connection.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AppointmentListListView_DoubleClick(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
