using WinFormsApp;

namespace PoligonOtomasyonu
{
    public partial class EmployeeBoardForm : Form
    {
        public EmployeeBoardForm()
        {
            InitializeComponent();
        }
        public string citizenId;
        private void button1_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.citizenId = citizenId;
            appointmentForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppointmentList appointmentListForm = new AppointmentList();
            appointmentListForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberList memberList = new MemberList();
            memberList.ShowDialog();
        }

        private void EmployeeBoardForm_Load(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            GunsDisplay gunsDisplay = new GunsDisplay();
            gunsDisplay.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
