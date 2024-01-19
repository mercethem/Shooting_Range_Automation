namespace PoligonOtomasyonu
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            equipmentlistView = new ListView();
            equipmentIdHeader = new ColumnHeader();
            trademarkHeader = new ColumnHeader();
            trademarkModelHeader = new ColumnHeader();
            gunLicenseHeader = new ColumnHeader();
            yearOfProductionHeader = new ColumnHeader();
            caliberHeader = new ColumnHeader();
            pistolHeader = new ColumnHeader();
            longBarrelRifleHeader = new ColumnHeader();
            lastMaintenanceHeader = new ColumnHeader();
            InMaintenanceHeader = new ColumnHeader();
            trademarkTextBox = new TextBox();
            trademarkModelTextBox = new TextBox();
            gunLicenseTextBox = new TextBox();
            yearofProductionTextBox = new TextBox();
            caliberTextBox = new TextBox();
            lastMaintenanceDateTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            saveButton = new Button();
            inMaintenanceCheckBox = new CheckBox();
            equipmentIdTextBox = new TextBox();
            label8 = new Label();
            weaponTypeComboBox = new ComboBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            buttonNewEquipment = new Button();
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // equipmentlistView
            // 
            equipmentlistView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            equipmentlistView.Columns.AddRange(new ColumnHeader[] { equipmentIdHeader, trademarkHeader, trademarkModelHeader, gunLicenseHeader, yearOfProductionHeader, caliberHeader, pistolHeader, longBarrelRifleHeader, lastMaintenanceHeader, InMaintenanceHeader });
            equipmentlistView.Location = new Point(12, 257);
            equipmentlistView.Name = "equipmentlistView";
            equipmentlistView.Size = new Size(1126, 381);
            equipmentlistView.TabIndex = 10;
            equipmentlistView.UseCompatibleStateImageBehavior = false;
            equipmentlistView.View = View.Details;
            equipmentlistView.DoubleClick += equipmentlistView_DoubleClick;
            // 
            // equipmentIdHeader
            // 
            equipmentIdHeader.Text = "EquipmentId";
            // 
            // trademarkHeader
            // 
            trademarkHeader.Text = "Trademark";
            trademarkHeader.Width = 100;
            // 
            // trademarkModelHeader
            // 
            trademarkModelHeader.Text = "TrademarkModel";
            trademarkModelHeader.Width = 220;
            // 
            // gunLicenseHeader
            // 
            gunLicenseHeader.Text = "GunLicense";
            gunLicenseHeader.Width = 100;
            // 
            // yearOfProductionHeader
            // 
            yearOfProductionHeader.Text = "YearOfProduction";
            yearOfProductionHeader.Width = 100;
            // 
            // caliberHeader
            // 
            caliberHeader.Text = "Caliber";
            caliberHeader.Width = 100;
            // 
            // pistolHeader
            // 
            pistolHeader.Text = "Pistol";
            pistolHeader.Width = 100;
            // 
            // longBarrelRifleHeader
            // 
            longBarrelRifleHeader.Text = "LongBarrelRifle";
            longBarrelRifleHeader.Width = 100;
            // 
            // lastMaintenanceHeader
            // 
            lastMaintenanceHeader.Text = "LastMaintenance";
            lastMaintenanceHeader.Width = 100;
            // 
            // InMaintenanceHeader
            // 
            InMaintenanceHeader.Text = "InMaintenance";
            InMaintenanceHeader.Width = 100;
            // 
            // trademarkTextBox
            // 
            trademarkTextBox.Location = new Point(225, 99);
            trademarkTextBox.Name = "trademarkTextBox";
            trademarkTextBox.Size = new Size(125, 30);
            trademarkTextBox.TabIndex = 0;
            // 
            // trademarkModelTextBox
            // 
            trademarkModelTextBox.Location = new Point(225, 141);
            trademarkModelTextBox.Name = "trademarkModelTextBox";
            trademarkModelTextBox.Size = new Size(125, 30);
            trademarkModelTextBox.TabIndex = 1;
            // 
            // gunLicenseTextBox
            // 
            gunLicenseTextBox.Location = new Point(225, 184);
            gunLicenseTextBox.Name = "gunLicenseTextBox";
            gunLicenseTextBox.Size = new Size(125, 30);
            gunLicenseTextBox.TabIndex = 2;
            // 
            // yearofProductionTextBox
            // 
            yearofProductionTextBox.Location = new Point(546, 53);
            yearofProductionTextBox.Name = "yearofProductionTextBox";
            yearofProductionTextBox.Size = new Size(125, 30);
            yearofProductionTextBox.TabIndex = 3;
            // 
            // caliberTextBox
            // 
            caliberTextBox.Location = new Point(546, 99);
            caliberTextBox.Name = "caliberTextBox";
            caliberTextBox.Size = new Size(125, 30);
            caliberTextBox.TabIndex = 4;
            // 
            // lastMaintenanceDateTimePicker
            // 
            lastMaintenanceDateTimePicker.Location = new Point(793, 99);
            lastMaintenanceDateTimePicker.Name = "lastMaintenanceDateTimePicker";
            lastMaintenanceDateTimePicker.Size = new Size(250, 30);
            lastMaintenanceDateTimePicker.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 10;
            label1.Text = "Trademark";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 148);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 11;
            label2.Text = "Trademark Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 12;
            label3.Text = "Gun License";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 61);
            label4.Name = "label4";
            label4.Size = new Size(154, 23);
            label4.TabIndex = 13;
            label4.Text = "Year Of Production";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 106);
            label5.Name = "label5";
            label5.Size = new Size(63, 23);
            label5.TabIndex = 14;
            label5.Text = "Caliber";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(793, 76);
            label6.Name = "label6";
            label6.Size = new Size(144, 23);
            label6.TabIndex = 15;
            label6.Text = "Last Maintenance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(386, 148);
            label7.Name = "label7";
            label7.Size = new Size(113, 23);
            label7.TabIndex = 17;
            label7.Text = "Weapon Type";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(793, 191);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(140, 52);
            saveButton.TabIndex = 8;
            saveButton.Text = "&Save and List";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += button1_Click;
            // 
            // inMaintenanceCheckBox
            // 
            inMaintenanceCheckBox.AutoSize = true;
            inMaintenanceCheckBox.Location = new Point(793, 150);
            inMaintenanceCheckBox.Name = "inMaintenanceCheckBox";
            inMaintenanceCheckBox.Size = new Size(287, 27);
            inMaintenanceCheckBox.TabIndex = 7;
            inMaintenanceCheckBox.Text = "&Is in Maintenance ? (Yes = Check)";
            inMaintenanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // equipmentIdTextBox
            // 
            equipmentIdTextBox.Enabled = false;
            equipmentIdTextBox.Location = new Point(225, 52);
            equipmentIdTextBox.Name = "equipmentIdTextBox";
            equipmentIdTextBox.Size = new Size(125, 30);
            equipmentIdTextBox.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 61);
            label8.Name = "label8";
            label8.Size = new Size(113, 23);
            label8.TabIndex = 23;
            label8.Text = "Equipment Id";
            // 
            // weaponTypeComboBox
            // 
            weaponTypeComboBox.FormattingEnabled = true;
            weaponTypeComboBox.Items.AddRange(new object[] { "Pistol", "LongBarrelRifle" });
            weaponTypeComboBox.Location = new Point(546, 146);
            weaponTypeComboBox.Name = "weaponTypeComboBox";
            weaponTypeComboBox.Size = new Size(125, 31);
            weaponTypeComboBox.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1021, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.White;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1066, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.DoubleClick += pictureBox3_DoubleClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Black;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1111, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1113, 40);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // buttonNewEquipment
            // 
            buttonNewEquipment.Location = new Point(972, 191);
            buttonNewEquipment.Name = "buttonNewEquipment";
            buttonNewEquipment.Size = new Size(140, 52);
            buttonNewEquipment.TabIndex = 9;
            buttonNewEquipment.Text = "&New Equipment";
            buttonNewEquipment.UseVisualStyleBackColor = true;
            buttonNewEquipment.Click += buttonNewEquipment_Click;
            // 
            // progressBar
            // 
            progressBar.Enabled = false;
            progressBar.Location = new Point(12, 222);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(338, 29);
            progressBar.TabIndex = 29;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 650);
            Controls.Add(progressBar);
            Controls.Add(buttonNewEquipment);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(equipmentIdTextBox);
            Controls.Add(inMaintenanceCheckBox);
            Controls.Add(saveButton);
            Controls.Add(label7);
            Controls.Add(weaponTypeComboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastMaintenanceDateTimePicker);
            Controls.Add(caliberTextBox);
            Controls.Add(yearofProductionTextBox);
            Controls.Add(gunLicenseTextBox);
            Controls.Add(trademarkModelTextBox);
            Controls.Add(trademarkTextBox);
            Controls.Add(equipmentlistView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Equipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipment";
            Load += Equipment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView equipmentlistView;
        private ColumnHeader trademarkHeader;
        private ColumnHeader trademarkModelHeader;
        private ColumnHeader gunLicenseHeader;
        private ColumnHeader yearOfProductionHeader;
        private ColumnHeader caliberHeader;
        private ColumnHeader pistolHeader;
        private ColumnHeader longBarrelRifleHeader;
        private ColumnHeader lastMaintenanceHeader;
        private ColumnHeader InMaintenanceHeader;
        private TextBox trademarkTextBox;
        private TextBox trademarkModelTextBox;
        private TextBox gunLicenseTextBox;
        private TextBox yearofProductionTextBox;
        private TextBox caliberTextBox;
        private DateTimePicker lastMaintenanceDateTimePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button saveButton;
        private CheckBox inMaintenanceCheckBox;
        private ColumnHeader equipmentIdHeader;
        private TextBox equipmentIdTextBox;
        private Label label8;
        private ComboBox weaponTypeComboBox;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button buttonNewEquipment;
        private ProgressBar progressBar;
    }
}