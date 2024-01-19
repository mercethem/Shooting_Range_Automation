namespace PoligonOtomasyonu
{
    partial class Accounting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting));
            label8 = new Label();
            billIdTextBox = new TextBox();
            saveButton = new Button();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gunLicenseTextBox = new TextBox();
            trademarkModelTextBox = new TextBox();
            trademarkTextBox = new TextBox();
            accountinglistView = new ListView();
            IdHeader = new ColumnHeader();
            trademarkHeader = new ColumnHeader();
            trademarkModelHeader = new ColumnHeader();
            gunLicenseHeader = new ColumnHeader();
            BillMaintenanceHeader = new ColumnHeader();
            maintenanceBillTextBox = new TextBox();
            totalCostTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 65);
            label8.Name = "label8";
            label8.Size = new Size(52, 23);
            label8.TabIndex = 42;
            label8.Text = "Bill Id";
            // 
            // billIdTextBox
            // 
            billIdTextBox.Enabled = false;
            billIdTextBox.Location = new Point(180, 62);
            billIdTextBox.Name = "billIdTextBox";
            billIdTextBox.Size = new Size(125, 30);
            billIdTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(1164, 88);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(174, 52);
            saveButton.TabIndex = 7;
            saveButton.Text = "&SAVE AND LIST";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 117);
            label6.Name = "label6";
            label6.Size = new Size(136, 23);
            label6.TabIndex = 36;
            label6.Text = "Maintenance Bill";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(766, 57);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 33;
            label3.Text = "Gun License";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 113);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 32;
            label2.Text = "Trademark Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 61);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 31;
            label1.Text = "Trademark";
            // 
            // gunLicenseTextBox
            // 
            gunLicenseTextBox.Location = new Point(874, 54);
            gunLicenseTextBox.Name = "gunLicenseTextBox";
            gunLicenseTextBox.Size = new Size(125, 30);
            gunLicenseTextBox.TabIndex = 4;
            // 
            // trademarkModelTextBox
            // 
            trademarkModelTextBox.Location = new Point(548, 106);
            trademarkModelTextBox.Name = "trademarkModelTextBox";
            trademarkModelTextBox.Size = new Size(125, 30);
            trademarkModelTextBox.TabIndex = 3;
            // 
            // trademarkTextBox
            // 
            trademarkTextBox.Location = new Point(548, 58);
            trademarkTextBox.Name = "trademarkTextBox";
            trademarkTextBox.Size = new Size(125, 30);
            trademarkTextBox.TabIndex = 2;
            // 
            // accountinglistView
            // 
            accountinglistView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            accountinglistView.Columns.AddRange(new ColumnHeader[] { IdHeader, trademarkHeader, trademarkModelHeader, gunLicenseHeader, BillMaintenanceHeader });
            accountinglistView.Location = new Point(12, 157);
            accountinglistView.Name = "accountinglistView";
            accountinglistView.Size = new Size(1326, 581);
            accountinglistView.TabIndex = 8;
            accountinglistView.UseCompatibleStateImageBehavior = false;
            accountinglistView.View = View.Details;
            accountinglistView.DoubleClick += accountinglistView_DoubleClick;
            // 
            // IdHeader
            // 
            IdHeader.Text = "Bill Id";
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
            // BillMaintenanceHeader
            // 
            BillMaintenanceHeader.Text = "BillMaintenance";
            BillMaintenanceHeader.Width = 150;
            // 
            // maintenanceBillTextBox
            // 
            maintenanceBillTextBox.Location = new Point(180, 110);
            maintenanceBillTextBox.Name = "maintenanceBillTextBox";
            maintenanceBillTextBox.Size = new Size(125, 30);
            maintenanceBillTextBox.TabIndex = 1;
            // 
            // totalCostTextBox
            // 
            totalCostTextBox.Location = new Point(874, 109);
            totalCostTextBox.Name = "totalCostTextBox";
            totalCostTextBox.Size = new Size(125, 30);
            totalCostTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(766, 116);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 45;
            label4.Text = "Total Cost";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1005, 112);
            label5.Name = "label5";
            label5.Size = new Size(43, 23);
            label5.TabIndex = 46;
            label5.Text = "USD";
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
            pictureBox4.TabIndex = 50;
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
            pictureBox3.TabIndex = 49;
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
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1296, 40);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(1077, 88);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(81, 52);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "&ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Accounting
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 750);
            Controls.Add(buttonAdd);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(totalCostTextBox);
            Controls.Add(maintenanceBillTextBox);
            Controls.Add(label8);
            Controls.Add(billIdTextBox);
            Controls.Add(saveButton);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gunLicenseTextBox);
            Controls.Add(trademarkModelTextBox);
            Controls.Add(trademarkTextBox);
            Controls.Add(accountinglistView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Accounting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accounting";
            Load += Accounting_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox billIdTextBox;
        private Button saveButton;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox gunLicenseTextBox;
        private TextBox trademarkModelTextBox;
        private TextBox trademarkTextBox;
        private ListView accountinglistView;
        private ColumnHeader IdHeader;
        private ColumnHeader trademarkHeader;
        private ColumnHeader trademarkModelHeader;
        private ColumnHeader gunLicenseHeader;
        private ColumnHeader BillMaintenanceHeader;
        private TextBox maintenanceBillTextBox;
        private TextBox totalCostTextBox;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button buttonAdd;
    }
}