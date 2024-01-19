namespace PoligonOtomasyonu
{
    partial class LoginEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginEmployee));
            button1 = new Button();
            textIdBox = new TextBox();
            textPasswordBox = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(155, 195);
            button1.Name = "button1";
            button1.Size = new Size(95, 35);
            button1.TabIndex = 2;
            button1.Text = "&Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textIdBox
            // 
            textIdBox.Location = new Point(20, 55);
            textIdBox.MaxLength = 11;
            textIdBox.Name = "textIdBox";
            textIdBox.Size = new Size(125, 30);
            textIdBox.TabIndex = 0;
            textIdBox.TextChanged += textIdBox_TextChanged;
            textIdBox.Enter += textIdBox_Enter;
            textIdBox.Leave += textIdBox_Leave;
            // 
            // textPasswordBox
            // 
            textPasswordBox.Location = new Point(20, 125);
            textPasswordBox.Name = "textPasswordBox";
            textPasswordBox.PasswordChar = '*';
            textPasswordBox.Size = new Size(125, 30);
            textPasswordBox.TabIndex = 1;
            textPasswordBox.UseSystemPasswordChar = true;
            textPasswordBox.Enter += textPasswordBox_Enter;
            textPasswordBox.Leave += textPasswordBox_Leave;
            // 
            // button2
            // 
            button2.Location = new Point(155, 255);
            button2.Name = "button2";
            button2.Size = new Size(95, 35);
            button2.TabIndex = 3;
            button2.Text = "&Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(155, 55);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 16;
            label1.Text = "Citizen ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(155, 125);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 17;
            label2.Text = "Password";
            // 
            // LoginEmployee
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textPasswordBox);
            Controls.Add(textIdBox);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textIdBox;
        private TextBox textPasswordBox;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}