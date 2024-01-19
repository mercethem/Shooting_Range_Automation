using WinFormsApp;

namespace PoligonOtomasyonu
{
    public partial class MemberBoardForm : Form
    {
        public string citizenId;
        public MemberBoardForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AppointmentForm appointment_Form = new AppointmentForm();
            appointment_Form.citizenId = citizenId;
            appointment_Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonInformation personInformation = new PersonInformation();
            personInformation.citizenId = citizenId;
            personInformation.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberAppointmentList memberAppointmentList = new MemberAppointmentList();
            memberAppointmentList.citizenId = citizenId;
            memberAppointmentList.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GunsDisplay gunsDisplay = new GunsDisplay();
            gunsDisplay.ShowDialog();
        }

        private void MemberBoardForm_Load(object sender, EventArgs e)
        {
            citizenIdlabel.Text = citizenId;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void citizenIdlabel_Click(object sender, EventArgs e)
        {
        }
    }
}
