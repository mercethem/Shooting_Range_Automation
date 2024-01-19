using System.Data.SqlClient;
using PoligonOtomasyonu.DataBase;

namespace PoligonOtomasyonu
{
    public partial class EmployeeList : Form
    {
        public string citizenId;

        public EmployeeList()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM login, personalInformation, contactInformation, employeeInformation WHERE (personalInformation.citizenId = contactInformation.citizenId AND personalInformation.citizenId = employeeInformation.citizenId AND login.citizenId = personalInformation.citizenId AND login.isEmployee = 'True') ORDER BY personalInformation.citizenId ASC", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = citizenId = reader["citizenId"].ToString().Trim();
                listViewItem.SubItems.Add(reader["name"].ToString().Trim());
                listViewItem.SubItems.Add(reader["midname"].ToString().Trim());
                listViewItem.SubItems.Add(reader["surname"].ToString().Trim());
                listViewItem.SubItems.Add(reader["gender"].ToString().Trim());
                listViewItem.SubItems.Add(reader["birthdate"].ToString().Trim());
                listViewItem.SubItems.Add(reader["bloodGroup"].ToString().Trim());
                listViewItem.SubItems.Add(reader["country"].ToString().Trim());
                listViewItem.SubItems.Add(reader["city"].ToString().Trim());
                listViewItem.SubItems.Add(reader["county"].ToString().Trim());
                listViewItem.SubItems.Add(reader["address"].ToString().Trim());
                listViewItem.SubItems.Add(reader["phone"].ToString().Trim());
                listViewItem.SubItems.Add(reader["email"].ToString().Trim());
                listViewItem.SubItems.Add(reader["criminalRecord"].ToString().Trim());
                listViewItem.SubItems.Add(reader["dateOfStart"].ToString().Trim());
                listViewItem.SubItems.Add(reader["dateOfFinish"].ToString().Trim());
                listViewItem.SubItems.Add(reader["employeeStatus"].ToString().Trim());

                EmployeeListListView.Items.Add(listViewItem);
            }
            reader.Close();
            connection.Close();
        }

        private void MemberListListView_DoubleClick(object sender, EventArgs e)
        {
            citizenId = EmployeeListListView.SelectedItems[0].SubItems[0].Text.Trim();
            MemberListPersonalInformation memberListPersonalInformation = new MemberListPersonalInformation();
            memberListPersonalInformation.citizenId = citizenId;
            memberListPersonalInformation.ShowDialog();
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
