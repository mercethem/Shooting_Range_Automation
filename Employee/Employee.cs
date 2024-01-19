namespace WinFormsApp
{
    class Employee : Member
    {
        const byte EMPLOYEE_ID_DIGIT_MAX = 11;

        private string employeeId;
        private bool employeeStatus;
        private DateTime dateOfStart;
        private DateTime dateofTermination;
        public string EmployeeId
        {
            get
            {
                return this.employeeId;
            }
            set
            {
                string s_employeeId = value.Trim().Replace(" ", "");
                if (ulong.TryParse(s_employeeId, out _) && s_employeeId.Length == EMPLOYEE_ID_DIGIT_MAX) //citizenId sayıysa ve max 11 haneliyse
                {
                    this.employeeId = s_employeeId;
                }
                else
                {
                    this.employeeId = "UNKNOWN";
                }
            }
        }
        public bool EmployeeStatus
        {
            get
            {
                return this.employeeStatus;
            }
            set
            {
                this.employeeStatus = value;
            }
        }
        public DateTime DateOfStart
        {
            get
            {
                return this.dateOfStart;
            }
            set
            {
                this.dateOfStart = value;
            }
        }
        public DateTime DateofTermination
        {
            get
            {
                return this.dateofTermination;
            }
            set
            {
                this.dateofTermination = value;
            }
        }
        public Employee()
        {

        }
        public Employee(string employeeId, bool employeeStatus, DateTime dateOfStart, DateTime dateofTermination)
        {
            this.employeeId = employeeId;
            this.employeeStatus = employeeStatus;
            this.dateOfStart = dateOfStart;
            this.dateofTermination = dateofTermination;
        }
    }
}
