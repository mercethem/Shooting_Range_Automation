namespace PoligonOtomasyonu
{
    partial class AdminBoardForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBoardForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timerClose = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Cross;
            button1.Location = new Point(661, 12);
            button1.Name = "button1";
            button1.Size = new Size(127, 62);
            button1.TabIndex = 0;
            button1.Text = "&Member List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Cross;
            button2.Location = new Point(661, 80);
            button2.Name = "button2";
            button2.Size = new Size(127, 62);
            button2.TabIndex = 1;
            button2.Text = "&Employee List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Cross;
            button3.Location = new Point(661, 148);
            button3.Name = "button3";
            button3.Size = new Size(127, 62);
            button3.TabIndex = 2;
            button3.Text = "&Appointment List";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Cross;
            button4.Location = new Point(145, 376);
            button4.Name = "button4";
            button4.Size = new Size(127, 62);
            button4.TabIndex = 5;
            button4.Text = "&Equipments";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Cross;
            button5.Location = new Point(661, 216);
            button5.Name = "button5";
            button5.Size = new Size(127, 62);
            button5.TabIndex = 3;
            button5.Text = "&Presentation";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Cross;
            button7.Location = new Point(12, 376);
            button7.Name = "button7";
            button7.Size = new Size(127, 62);
            button7.TabIndex = 4;
            button7.Text = "&Accounting";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Cross;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(691, 410);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 6;
            label1.Text = "&Logout";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(757, 409);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timerClose
            // 
            timerClose.Enabled = true;
            timerClose.Interval = 300000;
            timerClose.Tick += label1_Click;
            // 
            // AdminBoardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminBoardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminBoardForm";
            Load += AdminBoardForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerClose;
    }
}