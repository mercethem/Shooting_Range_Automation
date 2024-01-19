namespace PoligonOtomasyonu
{
    public partial class FirstChoose : Form
    {
        public FirstChoose()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GunsDisplay gunsDisplay = new GunsDisplay();
            gunsDisplay.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            newMemberSignIn newMemberSignIn = new newMemberSignIn();
            newMemberSignIn.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoginMember loginMember = new LoginMember();
            loginMember.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LoginEmployee loginEmployee = new LoginEmployee();
            loginEmployee.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.ShowDialog();
        }

        private void FirstChoose_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            newMemberSignIn newMemberSignIn = new newMemberSignIn();
            newMemberSignIn.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            GunsDisplay gunsDisplay = new GunsDisplay();
            gunsDisplay.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LoginMember loginMember = new LoginMember();
            loginMember.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoginEmployee loginEmployee = new LoginEmployee();
            loginEmployee.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.ShowDialog();
        }
    }
}
