namespace PoligonOtomasyonu
{
    partial class MemberAppointmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberAppointmentList));
            AppointmentListListView = new ListView();
            appointmentIdHeader = new ColumnHeader();
            citizenIdHeader = new ColumnHeader();
            appointmentDateHeader = new ColumnHeader();
            appointmentHourHeader = new ColumnHeader();
            appointmentRangeHeader = new ColumnHeader();
            appointmentCalendarTimePicker = new DateTimePicker();
            label2 = new Label();
            appointmentRangeComboBox = new ComboBox();
            appointmentCheckBox = new CheckBox();
            saveButton = new Button();
            label1 = new Label();
            appointmentHourComboBox = new ComboBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AppointmentListListView
            // 
            AppointmentListListView.Columns.AddRange(new ColumnHeader[] { appointmentIdHeader, citizenIdHeader, appointmentDateHeader, appointmentHourHeader, appointmentRangeHeader });
            AppointmentListListView.Location = new Point(12, 200);
            AppointmentListListView.Name = "AppointmentListListView";
            AppointmentListListView.Size = new Size(776, 238);
            AppointmentListListView.TabIndex = 5;
            AppointmentListListView.UseCompatibleStateImageBehavior = false;
            AppointmentListListView.View = View.Details;
            AppointmentListListView.DoubleClick += AppointmentListListView_DoubleClick;
            // 
            // appointmentIdHeader
            // 
            appointmentIdHeader.Text = "AppointmentId";
            // 
            // citizenIdHeader
            // 
            citizenIdHeader.Text = "CitizenId";
            citizenIdHeader.Width = 150;
            // 
            // appointmentDateHeader
            // 
            appointmentDateHeader.Text = "Date";
            appointmentDateHeader.TextAlign = HorizontalAlignment.Center;
            appointmentDateHeader.Width = 110;
            // 
            // appointmentHourHeader
            // 
            appointmentHourHeader.Text = "Hour";
            appointmentHourHeader.TextAlign = HorizontalAlignment.Center;
            appointmentHourHeader.Width = 100;
            // 
            // appointmentRangeHeader
            // 
            appointmentRangeHeader.Text = "Range";
            appointmentRangeHeader.TextAlign = HorizontalAlignment.Center;
            appointmentRangeHeader.Width = 100;
            // 
            // appointmentCalendarTimePicker
            // 
            appointmentCalendarTimePicker.Location = new Point(40, 70);
            appointmentCalendarTimePicker.MaxDate = new DateTime(2030, 12, 13, 0, 0, 0, 0);
            appointmentCalendarTimePicker.MinDate = new DateTime(2023, 12, 15, 0, 0, 0, 0);
            appointmentCalendarTimePicker.Name = "appointmentCalendarTimePicker";
            appointmentCalendarTimePicker.Size = new Size(250, 30);
            appointmentCalendarTimePicker.TabIndex = 0;
            appointmentCalendarTimePicker.Value = new DateTime(2023, 12, 15, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 120);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 13;
            label2.Text = "Range";
            // 
            // appointmentRangeComboBox
            // 
            appointmentRangeComboBox.FormattingEnabled = true;
            appointmentRangeComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            appointmentRangeComboBox.Location = new Point(342, 146);
            appointmentRangeComboBox.Name = "appointmentRangeComboBox";
            appointmentRangeComboBox.Size = new Size(118, 31);
            appointmentRangeComboBox.TabIndex = 2;
            // 
            // appointmentCheckBox
            // 
            appointmentCheckBox.AutoSize = true;
            appointmentCheckBox.Location = new Point(570, 87);
            appointmentCheckBox.Name = "appointmentCheckBox";
            appointmentCheckBox.Size = new Size(93, 27);
            appointmentCheckBox.TabIndex = 3;
            appointmentCheckBox.Text = "&Confirm";
            appointmentCheckBox.UseVisualStyleBackColor = true;
            appointmentCheckBox.CheckedChanged += appointmentCheckBox_CheckedChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(570, 120);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(129, 57);
            saveButton.TabIndex = 4;
            saveButton.Text = "&Save to Appointment";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.EnabledChanged += appointmentCheckBox_CheckedChanged;
            saveButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 44);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 9;
            label1.Text = "Appointment Hour";
            // 
            // appointmentHourComboBox
            // 
            appointmentHourComboBox.FormattingEnabled = true;
            appointmentHourComboBox.Items.AddRange(new object[] { "08:00", "08:15", "08:30", "08:45", "09:00", "09:15", "09:30", "09:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45", "16:00", "16:15", "16:30", "16:45", "17:00", "17:15", "17:30", "17:45", "18:00", "18:15", "18:30", "18:45", "19:00", "19:15", "19:30", "19:45", "20:00", "20:15", "20:30", "20:45", "21:00", "21:15", "21:30", "21:45", "22:00", "22:15", "22:30", "22:45" });
            appointmentHourComboBox.Location = new Point(342, 70);
            appointmentHourComboBox.Name = "appointmentHourComboBox";
            appointmentHourComboBox.Size = new Size(118, 31);
            appointmentHourComboBox.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(716, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Black;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(761, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 40);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // MemberAppointmentList
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(appointmentCalendarTimePicker);
            Controls.Add(label2);
            Controls.Add(appointmentRangeComboBox);
            Controls.Add(appointmentCheckBox);
            Controls.Add(saveButton);
            Controls.Add(label1);
            Controls.Add(appointmentHourComboBox);
            Controls.Add(AppointmentListListView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberAppointmentList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberAppointmentList";
            Load += MemberAppointmentList_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView AppointmentListListView;
        private ColumnHeader citizenIdHeader;
        private ColumnHeader appointmentDateHeader;
        private ColumnHeader appointmentHourHeader;
        private ColumnHeader appointmentRangeHeader;
        private DateTimePicker appointmentCalendarTimePicker;
        private Label label2;
        private ComboBox appointmentRangeComboBox;
        private CheckBox appointmentCheckBox;
        private Button saveButton;
        private Label label1;
        private ComboBox appointmentHourComboBox;
        private ColumnHeader appointmentIdHeader;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}