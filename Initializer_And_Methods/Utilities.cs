using System.Data.SqlClient;
using System.Media;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using PoligonOtomasyonu.DataBase;
using WinFormsApp;

namespace PoligonOtomasyonu.Initializer_And_Methods
{
    internal class Utilities
    {

        const byte CITIZEN_ID_DIGIT_MAX = 11;
        const byte PHONE_NUMBER_DIGIT = 10;
        const string PHONE_COUNTRY_CODE = "0090";
        const short YEAR_BASE = 1900;
        const byte E_MAIL_LETTER_MIN = 10;
        const byte E_MAIL_LETTER_MAX = 40;
        const byte GUN_LICENSE_DIGIT_MAX = 10;
        const byte NAME_LETTER_MAX = 20;
        const byte NAME_LETTER_MIN = 2;

        static SoundPlayer gunSound = new SoundPlayer(@"C:\ShootRangeAutomation\sounds\5.56.wav");
        static SoundPlayer triggerSound = new SoundPlayer(@"C:\ShootRangeAutomation\sounds\trigger.wav");
        static SoundPlayer reloadSound = new SoundPlayer(@"C:\ShootRangeAutomation\sounds\rifle_reload.wav");
        static SoundPlayer reloadSound2 = new SoundPlayer(@"C:\ShootRangeAutomation\sounds\rifle_reload2.wav");

        private bool IsName(string name)
        {
            string _name = name.Trim().Replace(" ", "");
            if (_name.Length > NAME_LETTER_MIN && Regex.IsMatch(_name, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private short IsValidYear(short year)
        {
            if (year < YEAR_BASE)
            {
                return YEAR_BASE;
            }
            else if (year >= DateTime.Now.Year)
            {
                return (short)DateTime.Now.Year;
            }
            else
            {
                return year;
            }
        }

        private byte IsValidMonth(byte month)
        {

            if (month <= 0)
            {
                return 1;
            }
            else if (month > 12)
            {
                return 12;
            }
            else
            {
                return month;
            }

        }

        private byte IsValidDay(byte day, short month, short year)
        {

            if (day <= 0)
            {
                return 1;
            }
            else if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0) && month == 2 && day >= 29)
            {
                return 29;
            }
            else if (!(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) && month == 2 && day >= 28)
            {
                return 28;
            }
            else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && day >= 31)
            {
                return 31;
            }
            else if ((month == 4 || month == 6 || month == 9 || month == 11) && day >= 30)
            {
                return 30;
            }
            else
            {
                return day;
            }
        }

        private string IsValidBloodGroup(string bloodGroup)
        {
            string _bloodGroup = bloodGroup.Trim().Replace(" ", "");
            switch (_bloodGroup.ToUpper())
            {
                case "ARH+": return "A RH+"; break;
                case "ARH-": return "A RH-"; break;
                case "BRH+": return "B RH+"; break;
                case "BRH-": return "B RH-"; break;
                case "ABRH+": return "AB RH+"; break;
                case "ABRH-": return "AB RH-"; break;
                case "0RH+": return "0 RH+"; break;
                case "0RH-": return "0 RH-"; break;
                default: return "Invalid blood group type!";
            }
        }

        private string IsValidPhoneNumber(string phoneNumber)
        {
            string _phoneNumber = phoneNumber.Trim().Replace(" ", "");
            if (_phoneNumber.Length == PHONE_NUMBER_DIGIT && Regex.IsMatch(_phoneNumber, @"^[0-9]+$"))
            {
                return PHONE_COUNTRY_CODE + _phoneNumber;
            }
            else
            {
                return "Invalid phone number";
            }
        }

        private string IsValidEmail(string eMail)
        {
            string _eMail = eMail.Trim().Replace(" ", "");
            if (_eMail.Contains("@") && _eMail.Length > E_MAIL_LETTER_MIN && _eMail.Length < E_MAIL_LETTER_MAX)  //TODO : Char mı string mi olması gerekiyor araştır kontrol et!
            {
                return _eMail.ToUpper();
            }
            else
            {
                return "Error : Invalid Email!";
            }
        }

        public static void PistolSound()
        {
            gunSound.Play();
        }
        public static void TriggerSound()
        {
            triggerSound.Play();
        }
        public static void ReloadSound()
        {
            reloadSound.Play();
        }
        public static void ReloadSound2()
        {
            reloadSound2.Play();
        }

        public void MemberGetValues(Member member, string citizenId)
        {
            SqlConnection connection = new SqlConnection(DatabaseConnection.DatabaseUrl());
            connection.Open();

            SqlCommand command = new SqlCommand("select * from ilceler where citizenId= '" + citizenId + "'", connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                member.CitizenId = sqlDataReader[0].ToString();
                member.Name = sqlDataReader[1].ToString();
                member.MidName = sqlDataReader[2].ToString();
                member.Surname = sqlDataReader[3].ToString();
                member.Gender = sqlDataReader[4].ToString();
                member.Birthdate = (DateTime)sqlDataReader[5];
                member.BloodGroup = sqlDataReader[6].ToString();
            }
        }

        public static void CriminalControlMailSend(string citizenId, string name, string surname)
        {

            string from, to, password, messageBody;
            to = "mercethem2@gmail.com".ToString();
            from = "mercethem2@hotmail.com".ToString();
            password = "2744543e";
            messageBody = "Citizen Id : " + citizenId.ToUpper().Trim() + "\n" +
                          "Name : " + name.ToUpper().Trim() + "\n" +
                          "Surname : " + surname.ToUpper().Trim() + "\n\n" +
                          "This person want to use SHOOTING RANGE,\n" +
                          "Please control the information for criminal record.";
            SmtpClient sc = new SmtpClient();
            sc.EnableSsl = true;
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.Credentials = new NetworkCredential(from, password);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(to);
            mail.Subject = "Criminal Record Control";
            mail.Body = messageBody;
            try
            {
                sc.Send(mail);
                MessageBox.Show("Mail sent successfully.", " Sent ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
