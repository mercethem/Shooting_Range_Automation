using System.Text.RegularExpressions;

namespace PoligonOtomasyonu.Person_Specifiers
{
    class Person
    {
        const byte CITIZEN_ID_DIGIT_MAX = 11;
        const byte NAME_LETTER_MAX = 20;
        const byte NAME_LETTER_MIN = 2;

        private string citizenId;
        private string name;
        private string midName;
        private string surname;
        private string gender;
        private DateTime birthdate;
        private string bloodGroup;
        private bool criminalRecord;

        public string CitizenId
        {
            get
            {
                return citizenId;
            }
            set
            {
                string _citizenId = value.Trim().Replace(" ", "");
                if (ulong.TryParse(_citizenId, out _) && _citizenId.Length == CITIZEN_ID_DIGIT_MAX) //citizenId sayıysa ve max 11 haneliyse
                {
                    citizenId = _citizenId;
                }
                else
                {
                    citizenId = "UNKNOWN";
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                string _name = value.Trim().Replace(" ", "");
                if (_name.Length >= 3 && _name.Length <= NAME_LETTER_MAX && Regex.IsMatch(_name, @"^[a-zA-Z]+$"))
                {
                    name = _name.ToUpper();
                }
                else
                {
                    name = "UNKNOWN";
                }
            }
        }
        public string MidName
        {
            get
            {
                return midName;
            }
            set
            {
                string _midName = value.Trim().Replace(" ", "");
                if (_midName.Length >= 3 && _midName.Length <= NAME_LETTER_MAX && Regex.IsMatch(_midName, @"^[a-zA-Z]+$"))
                {
                    midName = _midName.ToUpper();
                }
                else
                {
                    midName = "UNKNOWN";
                }
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                string _surname = value.Trim().Replace(" ", "");
                if (_surname.Length > NAME_LETTER_MIN && _surname.Length <= NAME_LETTER_MAX && Regex.IsMatch(_surname, @"^[a-zA-Z]+$"))
                {
                    surname = _surname.ToUpper();
                }
                else
                {
                    surname = "UNKNOWN";
                }
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                string _gender = value.Trim().ToUpper();
                if (value == "MALE")
                {
                    gender = "MALE";
                }
                else
                {
                    gender = "FEMALE";
                }
            }
        }
        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                birthdate = value;
            }
        }
        public string BloodGroup
        {
            get
            {
                return bloodGroup;
            }
            set
            {
                string _bloodGroup = value.Trim().Replace(" ", "").ToUpper();
                switch (_bloodGroup)
                {
                    case "ARH+": bloodGroup = "A RH+"; break;
                    case "ARH-": bloodGroup = "A RH-"; break;
                    case "BRH+": bloodGroup = "B RH+"; break;
                    case "BRH-": bloodGroup = "B RH-"; break;
                    case "ABRH+": bloodGroup = "AB RH+"; break;
                    case "ABRH-": bloodGroup = "AB RH-"; break;
                    case "0RH+": bloodGroup = "0 RH+"; break;
                    case "0RH-": bloodGroup = "0 RH-"; break;
                    default: bloodGroup = "UNKNOWN"; break;
                }
            }
        }
        public bool CriminalRecord
        {
            get
            {
                return criminalRecord;
            }
            set
            {
                if (value == true)
                {
                    criminalRecord = true;
                }
                else
                {
                    criminalRecord = false;
                }
            }
        }

        public Person()
        {

        }

        public Person(string citizenId, string name, string midName, string surname, string gender, DateTime birthdate,
                      string bloodGroup, bool criminalRecord)
        {
            this.citizenId = citizenId;
            this.name = name;
            this.midName = midName;
            this.surname = surname;
            this.gender = gender;
            this.birthdate = birthdate;
            this.bloodGroup = bloodGroup;
            this.criminalRecord = criminalRecord;
        }

        public int CalculateAge()
        {
            DateTime birthdate = this.birthdate;
            var today = DateTime.Today;
            var age = today.Year - birthdate.Year;
            if (birthdate.Date > today.AddYears(-age)) age--;
            return age;
        }

    }
}
