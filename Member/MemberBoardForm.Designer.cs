namespace PoligonOtomasyonu
{
    partial class MemberBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberBoardForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            citizenIdlabel = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            timerClose = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Cross;
            button1.Location = new Point(661, 80);
            button1.Name = "button1";
            button1.Size = new Size(127, 62);
            button1.TabIndex = 1;
            button1.Text = "&Make an Appointment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Cross;
            button2.Location = new Point(661, 12);
            button2.Name = "button2";
            button2.Size = new Size(127, 62);
            button2.TabIndex = 0;
            button2.Text = "Personal &Informations";
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
            button4.Location = new Point(661, 216);
            button4.Name = "button4";
            button4.Size = new Size(127, 62);
            button4.TabIndex = 3;
            button4.Text = "&Presentation";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // citizenIdlabel
            // 
            citizenIdlabel.AutoSize = true;
            citizenIdlabel.BackColor = Color.Transparent;
            citizenIdlabel.ForeColor = Color.White;
            citizenIdlabel.Location = new Point(15, 15);
            citizenIdlabel.Name = "citizenIdlabel";
            citizenIdlabel.Size = new Size(74, 23);
            citizenIdlabel.TabIndex = 4;
            citizenIdlabel.Text = "citizenId";
            citizenIdlabel.Click += citizenIdlabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(757, 409);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(691, 410);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 4;
            label1.Text = "Logout";
            label1.Click += label1_Click;
            // 
            // timerClose
            // 
            timerClose.Enabled = true;
            timerClose.Interval = 300000;
            timerClose.Tick += label1_Click;
            // 
            // MemberBoardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(citizenIdlabel);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberBoardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member_Board";
            Load += MemberBoardForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label citizenIdlabel;
        private PictureBox pictureBox1;
        private Label label1;
        private System.Windows.Forms.Timer timerClose;
    }
}