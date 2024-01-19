namespace PoligonOtomasyonu
{
    partial class MemberListPersonalInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberListPersonalInformation));
            labelUnderageAllert = new Label();
            textBoxAgeControl = new TextBox();
            ageTextBox = new TextBox();
            saveButton = new Button();
            bloodGroupComboBox = new ComboBox();
            countyComboBox = new ComboBox();
            cityComboBox = new ComboBox();
            genderComboBox = new ComboBox();
            birthdateDateTimePicker = new DateTimePicker();
            phoneNumberTextBox = new MaskedTextBox();
            addressTextBox = new RichTextBox();
            emailTextBox = new TextBox();
            label_eMail = new Label();
            label_phone = new Label();
            label3_address = new Label();
            countryTextBox = new TextBox();
            label_county = new Label();
            label_city = new Label();
            label_country = new Label();
            surnameTextBox = new TextBox();
            midnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            citizenIdTextBox = new TextBox();
            label_bloodGroup = new Label();
            label_birthdate = new Label();
            label_gender = new Label();
            label_surname = new Label();
            label_midname = new Label();
            label_name = new Label();
            label_citizenId = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            buttonCriminalControl = new Button();
            textBoxAdminCitizenId = new TextBox();
            textBoxAdminPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkCriminalControl = new CheckBox();
            checkBoxStatusSave = new CheckBox();
            buttonStatusSave = new Button();
            checkBoxIsMember = new CheckBox();
            checkBoxIsEmployee = new CheckBox();
            checkBoxIsAdmin = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelUnderageAllert
            // 
            labelUnderageAllert.AutoSize = true;
            labelUnderageAllert.Location = new Point(500, 246);
            labelUnderageAllert.Name = "labelUnderageAllert";
            labelUnderageAllert.Size = new Size(98, 23);
            labelUnderageAllert.TabIndex = 67;
            labelUnderageAllert.Text = "UNDERAGE";
            // 
            // textBoxAgeControl
            // 
            textBoxAgeControl.Enabled = false;
            textBoxAgeControl.Location = new Point(500, 272);
            textBoxAgeControl.Name = "textBoxAgeControl";
            textBoxAgeControl.Size = new Size(98, 30);
            textBoxAgeControl.TabIndex = 66;
            // 
            // ageTextBox
            // 
            ageTextBox.Enabled = false;
            ageTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ageTextBox.ForeColor = Color.Black;
            ageTextBox.Location = new Point(461, 271);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(33, 30);
            ageTextBox.TabIndex = 65;
            ageTextBox.TextChanged += ageTextBox_TextChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(483, 517);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(115, 60);
            saveButton.TabIndex = 13;
            saveButton.Text = "Save &Informations";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // bloodGroupComboBox
            // 
            bloodGroupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bloodGroupComboBox.FormattingEnabled = true;
            bloodGroupComboBox.Items.AddRange(new object[] { "A RH+", "A RH-", "B RH+", "B RH-", "AB RH +", "AB RH -", "0 RH +", "0 RH -" });
            bloodGroupComboBox.Location = new Point(179, 316);
            bloodGroupComboBox.Name = "bloodGroupComboBox";
            bloodGroupComboBox.Size = new Size(258, 31);
            bloodGroupComboBox.TabIndex = 6;
            // 
            // countyComboBox
            // 
            countyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countyComboBox.FormattingEnabled = true;
            countyComboBox.Location = new Point(179, 448);
            countyComboBox.Name = "countyComboBox";
            countyComboBox.Size = new Size(258, 31);
            countyComboBox.TabIndex = 9;
            // 
            // cityComboBox
            // 
            cityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(179, 402);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(258, 31);
            cityComboBox.TabIndex = 8;
            cityComboBox.SelectedIndexChanged += cityComboBox_SelectedIndexChanged;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "MALE", "FEMALE" });
            genderComboBox.Location = new Point(179, 232);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(258, 31);
            genderComboBox.TabIndex = 4;
            // 
            // birthdateDateTimePicker
            // 
            birthdateDateTimePicker.Location = new Point(179, 271);
            birthdateDateTimePicker.MaxDate = new DateTime(2023, 12, 13, 0, 0, 0, 0);
            birthdateDateTimePicker.MinDate = new DateTime(1900, 12, 13, 0, 0, 0, 0);
            birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            birthdateDateTimePicker.Size = new Size(258, 30);
            birthdateDateTimePicker.TabIndex = 5;
            birthdateDateTimePicker.Value = new DateTime(2023, 12, 13, 0, 0, 0, 0);
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(179, 497);
            phoneNumberTextBox.Mask = "(999) 000-0000";
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(258, 30);
            phoneNumberTextBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(483, 363);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(305, 116);
            addressTextBox.TabIndex = 12;
            addressTextBox.Text = "";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(179, 547);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(258, 30);
            emailTextBox.TabIndex = 11;
            // 
            // label_eMail
            // 
            label_eMail.AutoSize = true;
            label_eMail.Location = new Point(38, 550);
            label_eMail.Name = "label_eMail";
            label_eMail.Size = new Size(51, 23);
            label_eMail.TabIndex = 55;
            label_eMail.Text = "eMail";
            // 
            // label_phone
            // 
            label_phone.AutoSize = true;
            label_phone.Location = new Point(39, 500);
            label_phone.Name = "label_phone";
            label_phone.Size = new Size(59, 23);
            label_phone.TabIndex = 54;
            label_phone.Text = "Phone";
            // 
            // label3_address
            // 
            label3_address.AutoSize = true;
            label3_address.Location = new Point(483, 337);
            label3_address.Name = "label3_address";
            label3_address.Size = new Size(70, 23);
            label3_address.TabIndex = 53;
            label3_address.Text = "Address";
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(179, 360);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(258, 30);
            countryTextBox.TabIndex = 7;
            // 
            // label_county
            // 
            label_county.AutoSize = true;
            label_county.Location = new Point(38, 451);
            label_county.Name = "label_county";
            label_county.Size = new Size(65, 23);
            label_county.TabIndex = 51;
            label_county.Text = "County";
            // 
            // label_city
            // 
            label_city.AutoSize = true;
            label_city.Location = new Point(39, 405);
            label_city.Name = "label_city";
            label_city.Size = new Size(39, 23);
            label_city.TabIndex = 50;
            label_city.Text = "City";
            // 
            // label_country
            // 
            label_country.AutoSize = true;
            label_country.Location = new Point(38, 366);
            label_country.Name = "label_country";
            label_country.Size = new Size(71, 23);
            label_country.TabIndex = 49;
            label_country.Text = "Country";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(179, 188);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(258, 30);
            surnameTextBox.TabIndex = 3;
            // 
            // midnameTextBox
            // 
            midnameTextBox.Location = new Point(179, 145);
            midnameTextBox.Name = "midnameTextBox";
            midnameTextBox.Size = new Size(258, 30);
            midnameTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(179, 101);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(258, 30);
            nameTextBox.TabIndex = 1;
            // 
            // citizenIdTextBox
            // 
            citizenIdTextBox.Enabled = false;
            citizenIdTextBox.Location = new Point(179, 58);
            citizenIdTextBox.MaxLength = 11;
            citizenIdTextBox.Name = "citizenIdTextBox";
            citizenIdTextBox.Size = new Size(258, 30);
            citizenIdTextBox.TabIndex = 0;
            // 
            // label_bloodGroup
            // 
            label_bloodGroup.AutoSize = true;
            label_bloodGroup.Location = new Point(38, 319);
            label_bloodGroup.Name = "label_bloodGroup";
            label_bloodGroup.Size = new Size(107, 23);
            label_bloodGroup.TabIndex = 44;
            label_bloodGroup.Text = "Blood Group";
            // 
            // label_birthdate
            // 
            label_birthdate.AutoSize = true;
            label_birthdate.Location = new Point(38, 278);
            label_birthdate.Name = "label_birthdate";
            label_birthdate.Size = new Size(80, 23);
            label_birthdate.TabIndex = 43;
            label_birthdate.Text = "Birthdate";
            // 
            // label_gender
            // 
            label_gender.AutoSize = true;
            label_gender.Location = new Point(38, 235);
            label_gender.Name = "label_gender";
            label_gender.Size = new Size(66, 23);
            label_gender.TabIndex = 42;
            label_gender.Text = "Gender";
            // 
            // label_surname
            // 
            label_surname.AutoSize = true;
            label_surname.Location = new Point(38, 195);
            label_surname.Name = "label_surname";
            label_surname.Size = new Size(78, 23);
            label_surname.TabIndex = 41;
            label_surname.Text = "Surname";
            // 
            // label_midname
            // 
            label_midname.AutoSize = true;
            label_midname.Location = new Point(38, 152);
            label_midname.Name = "label_midname";
            label_midname.Size = new Size(82, 23);
            label_midname.TabIndex = 40;
            label_midname.Text = "Midname";
            label_midname.TextAlign = ContentAlignment.TopRight;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(38, 108);
            label_name.Name = "label_name";
            label_name.Size = new Size(56, 23);
            label_name.TabIndex = 39;
            label_name.Text = "Name";
            // 
            // label_citizenId
            // 
            label_citizenId.AutoSize = true;
            label_citizenId.Location = new Point(38, 65);
            label_citizenId.Name = "label_citizenId";
            label_citizenId.Size = new Size(82, 23);
            label_citizenId.TabIndex = 38;
            label_citizenId.Text = "Citizen Id";
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
            pictureBox4.TabIndex = 71;
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
            pictureBox2.TabIndex = 70;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 40);
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // buttonCriminalControl
            // 
            buttonCriminalControl.Location = new Point(728, 207);
            buttonCriminalControl.Name = "buttonCriminalControl";
            buttonCriminalControl.Size = new Size(94, 56);
            buttonCriminalControl.TabIndex = 22;
            buttonCriminalControl.Text = "&Criminal Control";
            buttonCriminalControl.UseVisualStyleBackColor = true;
            buttonCriminalControl.Click += buttonCriminalControl_Click;
            // 
            // textBoxAdminCitizenId
            // 
            textBoxAdminCitizenId.Location = new Point(658, 91);
            textBoxAdminCitizenId.MaxLength = 11;
            textBoxAdminCitizenId.Name = "textBoxAdminCitizenId";
            textBoxAdminCitizenId.Size = new Size(166, 30);
            textBoxAdminCitizenId.TabIndex = 18;
            // 
            // textBoxAdminPassword
            // 
            textBoxAdminPassword.Location = new Point(656, 145);
            textBoxAdminPassword.MaxLength = 11;
            textBoxAdminPassword.Name = "textBoxAdminPassword";
            textBoxAdminPassword.Size = new Size(166, 30);
            textBoxAdminPassword.TabIndex = 19;
            textBoxAdminPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(687, 65);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 75;
            label1.Text = "Admin Citizen Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(687, 124);
            label2.Name = "label2";
            label2.Size = new Size(135, 23);
            label2.TabIndex = 76;
            label2.Text = "Admin Password";
            // 
            // checkCriminalControl
            // 
            checkCriminalControl.AutoSize = true;
            checkCriminalControl.Location = new Point(661, 181);
            checkCriminalControl.Name = "checkCriminalControl";
            checkCriminalControl.Size = new Size(163, 27);
            checkCriminalControl.TabIndex = 20;
            checkCriminalControl.Text = "Are Sure For &Mail";
            checkCriminalControl.UseVisualStyleBackColor = true;
            checkCriminalControl.CheckedChanged += checkCriminalControl_CheckedChanged;
            // 
            // checkBoxStatusSave
            // 
            checkBoxStatusSave.AutoSize = true;
            checkBoxStatusSave.Location = new Point(461, 157);
            checkBoxStatusSave.Name = "checkBoxStatusSave";
            checkBoxStatusSave.Size = new Size(177, 27);
            checkBoxStatusSave.TabIndex = 17;
            checkBoxStatusSave.Text = "&Are Sure For Status";
            checkBoxStatusSave.UseVisualStyleBackColor = true;
            checkBoxStatusSave.CheckedChanged += checkBoxStatusSave_CheckedChanged;
            // 
            // buttonStatusSave
            // 
            buttonStatusSave.Location = new Point(459, 188);
            buttonStatusSave.Name = "buttonStatusSave";
            buttonStatusSave.Size = new Size(165, 30);
            buttonStatusSave.TabIndex = 21;
            buttonStatusSave.Text = "&Save Status";
            buttonStatusSave.UseVisualStyleBackColor = true;
            buttonStatusSave.Click += buttonStatusSave_Click;
            // 
            // checkBoxIsMember
            // 
            checkBoxIsMember.AutoSize = true;
            checkBoxIsMember.Location = new Point(459, 58);
            checkBoxIsMember.Name = "checkBoxIsMember";
            checkBoxIsMember.Size = new Size(96, 27);
            checkBoxIsMember.TabIndex = 14;
            checkBoxIsMember.Text = "&Member";
            checkBoxIsMember.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsEmployee
            // 
            checkBoxIsEmployee.AutoSize = true;
            checkBoxIsEmployee.Location = new Point(459, 83);
            checkBoxIsEmployee.Name = "checkBoxIsEmployee";
            checkBoxIsEmployee.Size = new Size(106, 27);
            checkBoxIsEmployee.TabIndex = 15;
            checkBoxIsEmployee.Text = "&Employee";
            checkBoxIsEmployee.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsAdmin
            // 
            checkBoxIsAdmin.AutoSize = true;
            checkBoxIsAdmin.Location = new Point(459, 108);
            checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            checkBoxIsAdmin.Size = new Size(82, 27);
            checkBoxIsAdmin.TabIndex = 16;
            checkBoxIsAdmin.Text = "&Admin";
            checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // MemberListPersonalInformation
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 650);
            Controls.Add(checkBoxIsAdmin);
            Controls.Add(checkBoxIsEmployee);
            Controls.Add(checkBoxIsMember);
            Controls.Add(buttonStatusSave);
            Controls.Add(checkBoxStatusSave);
            Controls.Add(checkCriminalControl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAdminPassword);
            Controls.Add(textBoxAdminCitizenId);
            Controls.Add(buttonCriminalControl);
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
            Name = "MemberListPersonalInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberListPersonalInformation";
            Load += MemberListPersonalInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUnderageAllert;
        private TextBox textBoxAgeControl;
        private TextBox ageTextBox;
        private Button saveButton;
        private ComboBox bloodGroupComboBox;
        private ComboBox countyComboBox;
        private ComboBox cityComboBox;
        private ComboBox genderComboBox;
        private DateTimePicker birthdateDateTimePicker;
        private MaskedTextBox phoneNumberTextBox;
        private RichTextBox addressTextBox;
        private TextBox emailTextBox;
        private Label label_eMail;
        private Label label_phone;
        private Label label3_address;
        private TextBox countryTextBox;
        private Label label_county;
        private Label label_city;
        private Label label_country;
        private TextBox surnameTextBox;
        private TextBox midnameTextBox;
        private TextBox nameTextBox;
        private TextBox citizenIdTextBox;
        private Label label_bloodGroup;
        private Label label_birthdate;
        private Label label_gender;
        private Label label_surname;
        private Label label_midname;
        private Label label_name;
        private Label label_citizenId;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button buttonCriminalControl;
        private TextBox textBoxAdminCitizenId;
        private TextBox textBoxAdminPassword;
        private Label label1;
        private Label label2;
        private CheckBox checkCriminalControl;
        private CheckBox checkBoxStatusSave;
        private Button buttonStatusSave;
        private CheckedListBox checkedListBoxStatus;
        private CheckBox checkBoxIsMember;
        private CheckBox checkBoxIsEmployee;
        private CheckBox checkBoxIsAdmin;
    }
}