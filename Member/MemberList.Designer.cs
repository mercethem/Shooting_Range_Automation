namespace WinFormsApp
{
    partial class MemberList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberList));
            MemberListListView = new ListView();
            citizenIdHeader = new ColumnHeader();
            nameHeader = new ColumnHeader();
            midnameHeader = new ColumnHeader();
            surnameHeader = new ColumnHeader();
            genderHeader = new ColumnHeader();
            birthdateHeader = new ColumnHeader();
            bloodGroupHeader = new ColumnHeader();
            countryHeader = new ColumnHeader();
            cityHeader = new ColumnHeader();
            countyHeader = new ColumnHeader();
            addressHeader = new ColumnHeader();
            phoneHeader = new ColumnHeader();
            emailHeader = new ColumnHeader();
            criminalRecordHeader = new ColumnHeader();
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
            // MemberListListView
            // 
            MemberListListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MemberListListView.Columns.AddRange(new ColumnHeader[] { citizenIdHeader, nameHeader, midnameHeader, surnameHeader, genderHeader, birthdateHeader, bloodGroupHeader, countryHeader, cityHeader, countyHeader, addressHeader, phoneHeader, emailHeader, criminalRecordHeader });
            MemberListListView.Location = new Point(12, 46);
            MemberListListView.Name = "MemberListListView";
            MemberListListView.Size = new Size(1326, 692);
            MemberListListView.TabIndex = 0;
            MemberListListView.UseCompatibleStateImageBehavior = false;
            MemberListListView.View = View.Details;
            MemberListListView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            MemberListListView.DoubleClick += MemberListListView_DoubleClick;
            // 
            // citizenIdHeader
            // 
            citizenIdHeader.Text = "CitizenId";
            citizenIdHeader.Width = 110;
            // 
            // nameHeader
            // 
            nameHeader.Text = "Name";
            nameHeader.TextAlign = HorizontalAlignment.Center;
            nameHeader.Width = 100;
            // 
            // midnameHeader
            // 
            midnameHeader.Text = "Midname";
            midnameHeader.TextAlign = HorizontalAlignment.Center;
            midnameHeader.Width = 100;
            // 
            // surnameHeader
            // 
            surnameHeader.Text = "Surname";
            surnameHeader.TextAlign = HorizontalAlignment.Center;
            surnameHeader.Width = 100;
            // 
            // genderHeader
            // 
            genderHeader.Text = "Gender";
            genderHeader.TextAlign = HorizontalAlignment.Center;
            genderHeader.Width = 90;
            // 
            // birthdateHeader
            // 
            birthdateHeader.Text = "Birthdate";
            birthdateHeader.TextAlign = HorizontalAlignment.Center;
            birthdateHeader.Width = 105;
            // 
            // bloodGroupHeader
            // 
            bloodGroupHeader.Text = "BloodGroup";
            bloodGroupHeader.TextAlign = HorizontalAlignment.Center;
            bloodGroupHeader.Width = 80;
            // 
            // countryHeader
            // 
            countryHeader.Text = "Country";
            countryHeader.Width = 80;
            // 
            // cityHeader
            // 
            cityHeader.Text = "City";
            cityHeader.Width = 100;
            // 
            // countyHeader
            // 
            countyHeader.Text = "County";
            countyHeader.Width = 100;
            // 
            // addressHeader
            // 
            addressHeader.Text = "Address";
            addressHeader.Width = 100;
            // 
            // phoneHeader
            // 
            phoneHeader.Text = "Phone";
            phoneHeader.Width = 100;
            // 
            // emailHeader
            // 
            emailHeader.Text = "Email";
            emailHeader.Width = 100;
            // 
            // criminalRecordHeader
            // 
            criminalRecordHeader.Text = "CriminalRecord";
            criminalRecordHeader.Width = 50;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1221, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.White;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1266, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
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
            pictureBox2.Location = new Point(1311, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(989, 40);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // MemberList
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 750);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(MemberListListView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView MemberListListView;
        private ColumnHeader citizenIdHeader;
        private ColumnHeader nameHeader;
        private ColumnHeader midnameHeader;
        private ColumnHeader surnameHeader;
        private ColumnHeader genderHeader;
        private ColumnHeader birthdateHeader;
        private ColumnHeader bloodGroupHeader;
        private ColumnHeader countryHeader;
        private ColumnHeader cityHeader;
        private ColumnHeader countyHeader;
        private ColumnHeader addressHeader;
        private ColumnHeader phoneHeader;
        private ColumnHeader emailHeader;
        private ColumnHeader criminalRecordHeader;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}