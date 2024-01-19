using System.Data.SqlClient;
using PoligonOtomasyonu.DataBase;
using PoligonOtomasyonu.Initializer_And_Methods;

namespace PoligonOtomasyonu
{
    public partial class Accounting : Form
    {
        long totalCost;
        public Accounting()
        {
            InitializeComponent();
            Accounting_Load();
            totalCostTextBox.Text = totalCost.ToString();
        }

        private void Accounting_Load(object sender, EventArgs e)
        {

        }
        private void Accounting_Load()
        {
            accountinglistView.Items.Clear();
            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM accounting", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["billId"].ToString().Trim();
                listViewItem.SubItems.Add(reader["trademark"].ToString().Trim());
                listViewItem.SubItems.Add(reader["trademarkModel"].ToString().Trim());
                listViewItem.SubItems.Add(reader["gunLicense"].ToString().Trim());
                listViewItem.SubItems.Add(reader["maintenanceBill"].ToString().Trim());
                totalCost += Convert.ToInt64(reader["maintenanceBill"].ToString().Trim());
                accountinglistView.Items.Add(listViewItem);

            }

            totalCostTextBox.Text = totalCost.ToString();
            reader.Close();
            connection.Close();

        }
        int billId;
        private void accountinglistView_DoubleClick(object sender, EventArgs e)
        {
            billId = Convert.ToInt32(accountinglistView.SelectedItems[0].SubItems[0].Text.Trim());
            billIdTextBox.Text = billId.ToString().Trim();
            trademarkTextBox.Text = accountinglistView.SelectedItems[0].SubItems[1].Text.Trim();
            trademarkModelTextBox.Text = accountinglistView.SelectedItems[0].SubItems[2].Text.Trim();
            gunLicenseTextBox.Text = accountinglistView.SelectedItems[0].SubItems[3].Text.Trim();
            maintenanceBillTextBox.Text = accountinglistView.SelectedItems[0].SubItems[4].Text.Trim();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            totalCost = 0;
            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();
            SqlCommand command = new SqlCommand(
                "UPDATE accounting SET trademark = '" + trademarkTextBox.Text.Trim() + "', trademarkModel = '" + trademarkModelTextBox.Text.Trim() + "'," +
                "gunLicense = '" + gunLicenseTextBox.Text.Trim() + "', " +
                "maintenanceBill = '" + maintenanceBillTextBox.Text.Trim() + "' WHERE billId = '" +
                billId + "'", connection);

            command.ExecuteNonQuery();
            connection.Close();

            Accounting_Load();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO accounting (trademark, trademarkModel, gunLicense, maintenanceBill)" +
                " VALUES ('" + trademarkTextBox.Text.Trim() + "', '" + trademarkModelTextBox.Text.Trim() + "', '" + gunLicenseTextBox.Text.Trim() + "', " +
                "'" + maintenanceBillTextBox.Text.Trim() + "' )", connection);
            command.ExecuteNonQuery();
            connection.Close();

            Utilities.PistolSound();
            MessageBox.Show("Success. Do not forget informations!!!", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Accounting_Load();
        }
    }
}
