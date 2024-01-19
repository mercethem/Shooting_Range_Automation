namespace WinFormsApp
{
    partial class PersonInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonInformation));
            label_citizenId = new Label();
            label_name = new Label();
            label_midname = new Label();
            label_surname = new Label();
            label_birthdate = new Label();
            label_gender = new Label();
            label_bloodGroup = new Label();
            citizenIdTextBox = new TextBox();
            midnameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            countryTextBox = new TextBox();
            label_county = new Label();
            label_city = new Label();
            label_country = new Label();
            emailTextBox = new TextBox();
            label_eMail = new Label();
            label_phone = new Label();
            label3_address = new Label();
            addressTextBox = new RichTextBox();
            phoneNumberTextBox = new MaskedTextBox();
            birthdateDateTimePicker = new DateTimePicker();
            nameTextBox = new TextBox();
            genderComboBox = new ComboBox();
            cityComboBox = new ComboBox();
            countyComboBox = new ComboBox();
            bloodGroupComboBox = new ComboBox();
            saveButton = new Button();
            ageTextBox = new TextBox();
            textBoxAgeControl = new TextBox();
            labelUnderageAllert = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label_citizenId
            // 
            label_citizenId.AutoSize = true;
            label_citizenId.Location = new Point(44, 67);
            label_citizenId.Name = "label_citizenId";
            label_citizenId.Size = new Size(82, 23);
            label_citizenId.TabIndex = 0;
            label_citizenId.Text = "Citizen Id";
            label_citizenId.Click += label1_Click;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(44, 110);
            label_name.Name = "label_name";
            label_name.Size = new Size(56, 23);
            label_name.TabIndex = 1;
            label_name.Text = "Name";
            label_name.Click += label2_Click;
            // 
            // label_midname
            // 
            label_midname.AutoSize = true;
            label_midname.Location = new Point(44, 154);
            label_midname.Name = "label_midname";
            label_midname.Size = new Size(82, 23);
            label_midname.TabIndex = 2;
            label_midname.Text = "Midname";
            label_midname.TextAlign = ContentAlignment.TopRight;
            label_midname.Click += label3_Click;
            // 
            // label_surname
            // 
            label_surname.AutoSize = true;
            label_surname.Location = new Point(44, 197);
            label_surname.Name = "label_surname";
            label_surname.Size = new Size(78, 23);
            label_surname.TabIndex = 3;
            label_surname.Text = "Surname";
            label_surname.Click += label4_Click;
            // 
            // label_birthdate
            // 
            label_birthdate.AutoSize = true;
            label_birthdate.Location = new Point(44, 280);
            label_birthdate.Name = "label_birthdate";
            label_birthdate.Size = new Size(80, 23);
            label_birthdate.TabIndex = 5;
            label_birthdate.Text = "Birthdate";
            // 
            // label_gender
            // 
            label_gender.AutoSize = true;
            label_gender.Location = new Point(44, 237);
            label_gender.Name = "label_gender";
            label_gender.Size = new Size(66, 23);
            label_gender.TabIndex = 4;
            label_gender.Text = "Gender";
            // 
            // label_bloodGroup
            // 
            label_bloodGroup.AutoSize = true;
            label_bloodGroup.Location = new Point(44, 321);
            label_bloodGroup.Name = "label_bloodGroup";
            label_bloodGroup.Size = new Size(107, 23);
            label_bloodGroup.TabIndex = 6;
            label_bloodGroup.Text = "Blood Group";
            label_bloodGroup.Click += label1_Click_1;
            // 
            // citizenIdTextBox
            // 
            citizenIdTextBox.Enabled = false;
            citizenIdTextBox.Location = new Point(185, 60);
            citizenIdTextBox.MaxLength = 11;
            citizenIdTextBox.Name = "citizenIdTextBox";
            citizenIdTextBox.Size = new Size(258, 30);
            citizenIdTextBox.TabIndex = 0;
            // 
            // midnameTextBox
            // 
            midnameTextBox.Location = new Point(185, 147);
            midnameTextBox.Name = "midnameTextBox";
            midnameTextBox.Size = new Size(258, 30);
            midnameTextBox.TabIndex = 2;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(185, 190);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(258, 30);
            surnameTextBox.TabIndex = 3;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(185, 362);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(258, 30);
            countryTextBox.TabIndex = 7;
            countryTextBox.TextChanged += textBox10_TextChanged;
            // 
            // label_county
            // 
            label_county.AutoSize = true;
            label_county.Location = new Point(44, 453);
            label_county.Name = "label_county";
            label_county.Size = new Size(65, 23);
            label_county.TabIndex = 16;
            label_county.Text = "County";
            // 
            // label_city
            // 
            label_city.AutoSize = true;
            label_city.Location = new Point(45, 407);
            label_city.Name = "label_city";
            label_city.Size = new Size(39, 23);
            label_city.TabIndex = 15;
            label_city.Text = "City";
            // 
            // label_country
            // 
            label_country.AutoSize = true;
            label_country.Location = new Point(44, 368);
            label_country.Name = "label_country";
            label_country.Size = new Size(71, 23);
            label_country.TabIndex = 14;
            label_country.Text = "Country";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(185, 549);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(258, 30);
            emailTextBox.TabIndex = 11;
            // 
            // label_eMail
            // 
            label_eMail.AutoSize = true;
            label_eMail.Location = new Point(44, 552);
            label_eMail.Name = "label_eMail";
            label_eMail.Size = new Size(51, 23);
            label_eMail.TabIndex = 22;
            label_eMail.Text = "eMail";
            // 
            // label_phone
            // 
            label_phone.AutoSize = true;
            label_phone.Location = new Point(45, 502);
            label_phone.Name = "label_phone";
            label_phone.Size = new Size(59, 23);
            label_phone.TabIndex = 21;
            label_phone.Text = "Phone";
            // 
            // label3_address
            // 
            label3_address.AutoSize = true;
            label3_address.Location = new Point(497, 341);
            label3_address.Name = "label3_address";
            label3_address.Size = new Size(70, 23);
            label3_address.TabIndex = 20;
            label3_address.Text = "Address";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(497, 367);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(305, 116);
            addressTextBox.TabIndex = 12;
            addressTextBox.Text = "";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(185, 499);
            phoneNumberTextBox.Mask = "(999) 000-0000";
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(258, 30);
            phoneNumberTextBox.TabIndex = 10;
            // 
            // birthdateDateTimePicker
            // 
            birthdateDateTimePicker.Location = new Point(185, 273);
            birthdateDateTimePicker.MaxDate = new DateTime(2023, 12, 14, 0, 0, 0, 0);
            birthdateDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            birthdateDateTimePicker.Size = new Size(258, 30);
            birthdateDateTimePicker.TabIndex = 5;
            birthdateDateTimePicker.Value = new DateTime(2023, 11, 11, 0, 0, 0, 0);
            birthdateDateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(185, 103);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(258, 30);
            nameTextBox.TabIndex = 1;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "MALE", "FEMALE" });
            genderComboBox.Location = new Point(185, 234);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(258, 31);
            genderComboBox.TabIndex = 4;
            genderComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cityComboBox
            // 
            cityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(185, 404);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(258, 31);
            cityComboBox.TabIndex = 8;
            cityComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            cityComboBox.SelectionChangeCommitted += comboBox_city_SelectionChangeCommitted;
            // 
            // countyComboBox
            // 
            countyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countyComboBox.FormattingEnabled = true;
            countyComboBox.Location = new Point(185, 450);
            countyComboBox.Name = "countyComboBox";
            countyComboBox.Size = new Size(258, 31);
            countyComboBox.TabIndex = 9;
            countyComboBox.SelectedIndexChanged += comboBox_county_SelectedIndexChanged;
            // 
            // bloodGroupComboBox
            // 
            bloodGroupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bloodGroupComboBox.FormattingEnabled = true;
            bloodGroupComboBox.ItemHeight = 23;
            bloodGroupComboBox.Items.AddRange(new object[] { "A RH+", "A RH-", "B RH+", "B RH-", "AB RH +", "AB RH -", "0 RH +", "0 RH -" });
            bloodGroupComboBox.Location = new Point(185, 318);
            bloodGroupComboBox.Name = "bloodGroupComboBox";
            bloodGroupComboBox.Size = new Size(258, 31);
            bloodGroupComboBox.TabIndex = 32;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(497, 530);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 51);
            saveButton.TabIndex = 13;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += button1_Click;
            // 
            // ageTextBox
            // 
            ageTextBox.Enabled = false;
            ageTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ageTextBox.ForeColor = Color.Black;
            ageTextBox.Location = new Point(475, 275);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(33, 30);
            ageTextBox.TabIndex = 35;
            ageTextBox.TextChanged += ageTextBox_TextChanged;
            // 
            // textBoxAgeControl
            // 
            textBoxAgeControl.Enabled = false;
            textBoxAgeControl.Location = new Point(514, 276);
            textBoxAgeControl.Name = "textBoxAgeControl";
            textBoxAgeControl.Size = new Size(98, 30);
            textBoxAgeControl.TabIndex = 36;
            // 
            // labelUnderageAllert
            // 
            labelUnderageAllert.AutoSize = true;
            labelUnderageAllert.Location = new Point(514, 250);
            labelUnderageAllert.Name = "labelUnderageAllert";
            labelUnderageAllert.Size = new Size(98, 23);
            labelUnderageAllert.TabIndex = 37;
            labelUnderageAllert.Text = "UNDERAGE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(958, 40);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(766, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Black;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(811, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PersonInformation
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 650);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelUnderageAllert);
            Controls.Add(textBoxAgeControl);
            Controls.Add(ageTextBox);
            Controls.Add(saveButton);
            Controls.Add(bloodGroupComboBox);
            Controls.Add(countyComboBox);
            Controls.Add(cityComboBox);
            Controls.Add(genderComboBox);
            Controls.Add(birthdateDateTimePicker);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(label_eMail);
            Controls.Add(label_phone);
            Controls.Add(label3_address);
            Controls.Add(countryTextBox);
            Controls.Add(label_county);
            Controls.Add(label_city);
            Controls.Add(label_country);
            Controls.Add(surnameTextBox);
            Controls.Add(midnameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(citizenIdTextBox);
            Controls.Add(label_bloodGroup);
            Controls.Add(label_birthdate);
            Controls.Add(label_gender);
            Controls.Add(label_surname);
            Controls.Add(label_midname);
            Controls.Add(label_name);
            Controls.Add(label_citizenId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PersonInformation";
            Load += PersonInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_citizenId;
        private Label label_name;
        private Label label_midname;
        private Label label_surname;
        private Label label_birthdateDay;
        private Label label_birthdateMonth;
        private Label label_birthdate;
        private Label label_gender;
        private Label label_bloodGroup;
        private TextBox citizenIdTextBox;
        private TextBox midnameTextBox;
        private TextBox surnameTextBox;
        private TextBox textBox8;
        private TextBox countryTextBox;
        private Label label_county;
        private Label label_city;
        private Label label_country;
        private TextBox emailTextBox;
        private Label label_eMail;
        private Label label_phone;
        private Label label3_address;
        private RichTextBox addressTextBox;
        private MaskedTextBox phoneNumberTextBox;
        private DateTimePicker birthdateDateTimePicker;
        private TextBox nameTextBox;
        private ComboBox genderComboBox;
        private ComboBox cityComboBox;
        private ComboBox countyComboBox;
        private ComboBox bloodGroupComboBox;
        private Button saveButton;
        private TextBox ageTextBox;
        private TextBox textBoxAgeControl;
        private Label labelUnderageAllert;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
    }
}