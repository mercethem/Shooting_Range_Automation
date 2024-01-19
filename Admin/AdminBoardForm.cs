using WinFormsApp;

namespace PoligonOtomasyonu
{

    public partial class AdminBoardForm : Form
    {
        public string citizenId;

        public AdminBoardForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppointmentList appointmentList = new AppointmentList();
            appointmentList.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberList memberList = new MemberList();
            memberList.citizenId = citizenId;
            memberList.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList = new EmployeeList();
            employeeList.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GunsDisplay gunsDisplay = new GunsDisplay();
            gunsDisplay.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            equipment.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Accounting accounting = new Accounting();
            accounting.ShowDialog();
        }

        private void AdminBoardForm_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }
    }
}
