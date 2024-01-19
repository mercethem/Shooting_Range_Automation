using System.Text.RegularExpressions;

namespace PoligonOtomasyonu.Person_Specifiers
{
    internal class ContactInformation : Person
    {
        const byte PHONE_NUMBER_DIGIT = 10;
        const byte E_MAIL_LETTER_MIN = 10;
        const byte E_MAIL_LETTER_MAX = 40;
        const byte NAME_LETTER_MAX = 20;
        const byte NAME_LETTER_MIN = 2;

        private string country;
        private string city;
        private string county;
        private string address;
        private string phone;
        private string email;

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                string _country = value.Trim().Replace(" ", "");
                if (_country.Length >= NAME_LETTER_MIN && _country.Length <= NAME_LETTER_MAX && Regex.IsMatch(_country, @"^[a-zA-Z]+$"))
                {
                    country = _country.ToUpper();
                }
                else
                {
                    country = "UNKNOWN";
                }
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                string _city = value.Trim().Replace(" ", "");
                if (_city.Length >= NAME_LETTER_MIN && _city.Length <= NAME_LETTER_MAX && Regex.IsMatch(_city, @"^[a-zA-Z]+$"))
                {
                    city = _city.ToUpper();
                }
                else
                {
                    city = "UNKNOWN";
                }
            }
        }
        public string County
        {
            get
            {
                return county;
            }
            set
            {
                string _county = value.Trim().Replace(" ", "");
                if (_county.Length >= 2 && Regex.IsMatch(_county, @"^[a-zA-Z]+$"))
                {
                    county = _county.ToUpper();
                }
                else
                {
                    county = "UNKNOWN";
                }
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                string _address = value.Trim();
                if (_address.Length > 5)
                {
                    address = _address.ToUpper();
                }
                else
                {
                    address = "UNKNOWN";
                }
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                string _phone = value.Trim().Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "");
                if (_phone.Length == PHONE_NUMBER_DIGIT && Regex.IsMatch(_phone, @"^[0-9]+$")) //TODO : trimin tüm boşlukları sildiğine emin ol
                {
                    phone = _phone;
                }
                else
                {
                    phone = "0000000000";
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                string _email = value.Trim().Replace(" ", "");
                if (_email.Contains('@') && _email.Length > E_MAIL_LETTER_MIN && _email.Length < E_MAIL_LETTER_MAX)  //TODO : Char mı string mi olması gerekiyor araştır kontrol et!
                {
                    email = _email.ToUpper();
                }
                else
                {
                    email = "UNKNOWN";
                }
            }
        }

        public ContactInformation()
        {
        }

        public ContactInformation(string country, string city, string county, string address, string phone, string eMail)
        {
            this.country = country;
            this.city = city;
            this.county = county;
            this.address = address;
            this.phone = phone;
            email = email;
        }
    }
}
