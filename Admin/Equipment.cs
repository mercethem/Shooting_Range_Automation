using System.Data.SqlClient;
using PoligonOtomasyonu.DataBase;
using PoligonOtomasyonu.Initializer_And_Methods;

namespace PoligonOtomasyonu
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }
        private void Equipment_Load()
        {
            equipmentlistView.Items.Clear();
            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM equipment", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                progressBar.Increment(1);

                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["equipmentId"].ToString().Trim();
                listViewItem.SubItems.Add(reader["trademark"].ToString().Trim());
                listViewItem.SubItems.Add(reader["trademarkModel"].ToString().Trim());
                listViewItem.SubItems.Add(reader["gunLicense"].ToString().Trim());
                listViewItem.SubItems.Add(reader["yearOfProduction"].ToString().Trim());
                listViewItem.SubItems.Add(reader["caliber"].ToString().Trim());
                listViewItem.SubItems.Add(reader["isPistol"].ToString().Trim());
                listViewItem.SubItems.Add(reader["isLongBarrelRifle"].ToString().Trim());
                listViewItem.SubItems.Add(reader["lastMaintenance"].ToString().Trim());
                listViewItem.SubItems.Add(reader["isInMaintenance"].ToString().Trim());
                equipmentlistView.Items.Add(listViewItem);

                if (listViewItem.SubItems[9].Text.Trim() == "True")
                {
                    listViewItem.BackColor = Color.Red;
                }
            }


            reader.Close();
            connection.Close();
            progressBar.Value = 100;

        }

        int equipmentId;
        private void equipmentlistView_DoubleClick(object sender, EventArgs e)
        {
            equipmentId = Convert.ToInt32(equipmentlistView.SelectedItems[0].SubItems[0].Text.Trim());
            equipmentIdTextBox.Text = equipmentId.ToString().Trim();
            trademarkTextBox.Text = equipmentlistView.SelectedItems[0].SubItems[1].Text.Trim();
            trademarkModelTextBox.Text = equipmentlistView.SelectedItems[0].SubItems[2].Text.Trim();
            gunLicenseTextBox.Text = equipmentlistView.SelectedItems[0].SubItems[3].Text.Trim();
            yearofProductionTextBox.Text = equipmentlistView.SelectedItems[0].SubItems[4].Text.Trim();
            caliberTextBox.Text = equipmentlistView.SelectedItems[0].SubItems[5].Text.Trim();

            if (equipmentlistView.SelectedItems[0].SubItems[6].Text.Trim() == "True")
            {
                weaponTypeComboBox.Text = "Pistol";
            }
            else if (equipmentlistView.SelectedItems[0].SubItems[6].Text.Trim() == "False")
            {
                weaponTypeComboBox.Text = "LongBarrelRifle";
            }
            lastMaintenanceDateTimePicker.Value = Convert.ToDateTime(equipmentlistView.SelectedItems[0].SubItems[8].Text.Trim());
            inMaintenanceCheckBox.Checked = (equipmentlistView.SelectedItems[0].SubItems[9].Text.Trim() == "True");
        }


        SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
        private void button1_Click(object sender, EventArgs e)
        {
            bool isPistol = false;
            bool isLongBarrelRifle = false;

            if (weaponTypeComboBox.Text.Trim() == "Pistol")
            {
                isPistol = true;
            }
            else if (weaponTypeComboBox.Text.Trim() == "LongBarrelRifle")
            {
                isLongBarrelRifle = true;
            }

            connection.Open();
            SqlCommand command = new SqlCommand(
                "UPDATE equipment SET trademark = '" + trademarkTextBox.Text.Trim() + "', trademarkModel = '" + trademarkModelTextBox.Text.Trim() + "'," +
                " gunLicense = '" + gunLicenseTextBox.Text.Trim() + "', yearOfProduction = '" + yearofProductionTextBox.Text.Trim() + "', caliber = '" +
                caliberTextBox.Text.Trim() + "', isPistol = '" + isPistol + "', isLongBarrelRifle = '" + isLongBarrelRifle + "', lastMaintenance = '" +
                lastMaintenanceDateTimePicker.Value.ToString("yyyy-MM-dd").Trim() + "', isInMaintenance = '" + inMaintenanceCheckBox.Checked + "' WHERE equipmentId = '" +
                equipmentId + "'", connection);

            command.ExecuteNonQuery();
            connection.Close();
            Equipment_Load();
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

        private void buttonNewEquipment_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();

            SqlCommand commandSignIn = new SqlCommand("INSERT INTO equipment (trademark, trademarkModel, gunLicense, yearOfProduction, caliber)" +
                " VALUES ('" + trademarkTextBox.Text.Trim() + "', '" + trademarkModelTextBox.Text.Trim() + "', '" + gunLicenseTextBox.Text.Trim() + "', " +
                "'" + yearofProductionTextBox.Text.Trim() + "', '" + caliberTextBox.Text.Trim() + "')", connection);
            commandSignIn.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Kayıt Oldunuz. Eksik bilgileri Tamamlamayı Unutmayınız!!!", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Utilities.PistolSound();
            Equipment_Load();
        }
    }
}
