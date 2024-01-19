using WinFormsApp;

namespace PoligonOtomasyonu.Appointment
{
    internal class Appointment : Member
    {
        private DateTime appointmentDate;
        private TimeOnly appointmentHour;
        private byte appointmentRange;

        public DateTime Date
        {
            get
            {
                return appointmentDate;
            }
            set
            {
                appointmentDate = value;
            }
        }
        public TimeOnly AppointmentHour
        {
            get
            {
                return appointmentHour;
            }
            set
            {
                appointmentHour = value;
            }

        }
        public byte AppointmentRange
        {
            set
            {
                appointmentRange = value;
            }
            get
            {
                return appointmentRange;
            }
        }
        public Appointment() { }

        public Appointment(byte appointmentRange, DateTime appointmentDate, TimeOnly appointmentHour)
        {
            this.appointmentRange = appointmentRange;
            this.appointmentDate = appointmentDate;
            this.appointmentHour = appointmentHour;
        }
    }
}
