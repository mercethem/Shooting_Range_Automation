namespace WinFormsApp
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            appointmentHourComboBox = new ComboBox();
            label1 = new Label();
            saveButton = new Button();
            appointmentCheckBox = new CheckBox();
            appointmentRangeComboBox = new ComboBox();
            label2 = new Label();
            appointmentCalendarTimePicker = new DateTimePicker();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // appointmentHourComboBox
            // 
            appointmentHourComboBox.FormattingEnabled = true;
            appointmentHourComboBox.Items.AddRange(new object[] { "08:00", "08:15", "08:30", "08:45", "09:00", "09:15", "09:30", "09:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45", "16:00", "16:15", "16:30", "16:45", "17:00", "17:15", "17:30", "17:45", "18:00", "18:15", "18:30", "18:45", "19:00", "19:15", "19:30", "19:45", "20:00", "20:15", "20:30", "20:45", "21:00", "21:15", "21:30", "21:45", "22:00", "22:15", "22:30", "22:45" });
            appointmentHourComboBox.Location = new Point(304, 96);
            appointmentHourComboBox.Name = "appointmentHourComboBox";
            appointmentHourComboBox.Size = new Size(118, 31);
            appointmentHourComboBox.TabIndex = 1;
            appointmentHourComboBox.SelectedIndexChanged += AppointmentHour_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 70);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 2;
            label1.Text = "Appointment Hour";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(304, 250);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(129, 57);
            saveButton.TabIndex = 4;
            saveButton.Text = "&Save to Appointment";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += button1_Click;
            // 
            // appointmentCheckBox
            // 
            appointmentCheckBox.AutoSize = true;
            appointmentCheckBox.Location = new Point(304, 217);
            appointmentCheckBox.Name = "appointmentCheckBox";
            appointmentCheckBox.Size = new Size(93, 27);
            appointmentCheckBox.TabIndex = 3;
            appointmentCheckBox.Text = "&Confirm";
            appointmentCheckBox.UseVisualStyleBackColor = true;
            appointmentCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // appointmentRangeComboBox
            // 
            appointmentRangeComboBox.FormattingEnabled = true;
            appointmentRangeComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            appointmentRangeComboBox.Location = new Point(304, 156);
            appointmentRangeComboBox.Name = "appointmentRangeComboBox";
            appointmentRangeComboBox.Size = new Size(118, 31);
            appointmentRangeComboBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 130);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 6;
            label2.Text = "Range";
            // 
            // appointmentCalendarTimePicker
            // 
            appointmentCalendarTimePicker.Location = new Point(27, 97);
            appointmentCalendarTimePicker.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            appointmentCalendarTimePicker.MinDate = new DateTime(2023, 12, 13, 0, 0, 0, 0);
            appointmentCalendarTimePicker.Name = "appointmentCalendarTimePicker";
            appointmentCalendarTimePicker.Size = new Size(250, 30);
            appointmentCalendarTimePicker.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(380, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Black;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(425, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 40);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 350);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment_Form";
            Load += Appointment_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox appointmentHourComboBox;
        private Label label1;
        private Button saveButton;
        private CheckBox appointmentCheckBox;
        private ComboBox appointmentRangeComboBox;
        private Label label2;
        private DateTimePicker appointmentCalendarTimePicker;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}