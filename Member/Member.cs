using PoligonOtomasyonu.Person_Specifiers;

namespace WinFormsApp
{
    class Member : ContactInformation
    {

        private bool membershipStatus;
        private DateTime membershipDateOfStart;
        private DateTime membershipDateOfTermination;
        public bool MembershipStatus
        {
            get
            {
                return this.membershipStatus;
            }
            set
            {
                this.membershipStatus = true;
            }
        }
        public DateTime MembershipDateOfStart
        {
            get
            {
                return this.membershipDateOfStart;
            }
            set
            {
                this.membershipDateOfStart = value;
            }
        }
        public DateTime MembershipYearOfTermination
        {
            get
            {
                return this.membershipDateOfTermination;
            }
            set
            {
                this.membershipDateOfTermination = value;
            }
        }

        public Member()
        {
        }
        public Member(bool membershipStatus, DateTime membershipDateOfStart, DateTime membershipDateOfTermination)
        {
            this.membershipStatus = membershipStatus;
            this.membershipDateOfStart = membershipDateOfStart;
            this.membershipDateOfTermination = membershipDateOfTermination;
        }

        public int MembershipDuration()
        {
            DateTime membershipDateOfStart = this.membershipDateOfStart;
            var today = DateTime.Today;
            var membershipDuration = today.Year - membershipDateOfStart.Year;
            if (membershipDateOfStart.Date > today.AddYears(-membershipDuration)) membershipDuration--;
            return membershipDuration;
        }
    }
}
