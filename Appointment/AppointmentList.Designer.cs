namespace WinFormsApp
{
    partial class AppointmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentList));
            AppointmentListListView = new ListView();
            citizenIdHeader = new ColumnHeader();
            appointmentDateHeader = new ColumnHeader();
            appointmentHourHeader = new ColumnHeader();
            appointmentRangeHeader = new ColumnHeader();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AppointmentListListView
            // 
            AppointmentListListView.Columns.AddRange(new ColumnHeader[] { citizenIdHeader, appointmentDateHeader, appointmentHourHeader, appointmentRangeHeader });
            AppointmentListListView.Location = new Point(12, 51);
            AppointmentListListView.Name = "AppointmentListListView";
            AppointmentListListView.Size = new Size(776, 387);
            AppointmentListListView.TabIndex = 0;
            AppointmentListListView.UseCompatibleStateImageBehavior = false;
            AppointmentListListView.View = View.Details;
            AppointmentListListView.SelectedIndexChanged += AppointmentListListView_DoubleClick;
            AppointmentListListView.DoubleClick += AppointmentListListView_DoubleClick;
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
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(671, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.White;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(716, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
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
            pictureBox2.Location = new Point(761, 0);
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
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 40);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // AppointmentList
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(AppointmentListListView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppointmentList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AppointmentList_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView AppointmentListListView;
        private ColumnHeader citizenIdHeader;
        private ColumnHeader appointmentDateHeader;
        private ColumnHeader appointmentHourHeader;
        private ColumnHeader appointmentRangeHeader;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}