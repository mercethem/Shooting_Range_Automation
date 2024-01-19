using System.Text.RegularExpressions;

namespace PoligonOtomasyonu.Weapons_And_Guns
{
    class Gun
    {
        const int GUN_LICENSE_DIGIT_MAX = 10;
        const int TRADEMARK_LETTER_MAX = 20;
        const int GUN_YEAR_BASE = 2000;

        private string trademark;
        private string trademarkModel;
        private string gunLicense;
        private short yearOfProduction;
        private string caliber;

        public string Trademark
        {
            get
            {
                return trademark;
            }
            set
            {
                string _trademark = value.Trim().Replace(" ", "");
                if (_trademark.Length >= 3 && _trademark.Length <= TRADEMARK_LETTER_MAX && Regex.IsMatch(_trademark, @"^[a-zA-Z]+$"))
                {
                    trademark = _trademark.ToUpper();
                }
                else
                {
                    trademark = "UNKNOWN";
                }
            }
        }
        public string TrademarkModel
        {
            get
            {
                return trademarkModel;
            }
            set
            {
                string _trademarkModel = value.Trim().Replace(" ", "");
                if (_trademarkModel.Length >= 3 && _trademarkModel.Length <= TRADEMARK_LETTER_MAX && Regex.IsMatch(_trademarkModel, @"^[a-zA-Z]+$"))
                {
                    trademarkModel = _trademarkModel.ToUpper();
                }
                else
                {
                    trademarkModel = "UNKNOWN";
                }
            }
        }
        public string GunLicense
        {
            get
            {
                return gunLicense;
            }
            set
            {
                string _gunLicense = value.Trim().Replace(" ", "");
                if (ulong.TryParse(_gunLicense, out _) && _gunLicense.Length == GUN_LICENSE_DIGIT_MAX) //citizenId sayıysa ve max 11 haneliyse
                {
                    gunLicense = _gunLicense;
                }
                else
                {
                    gunLicense = "UNKNOWN";
                }
            }
        }
        public short YearOfProduction
        {
            get
            {
                return yearOfProduction;
            }
            set
            {
                string _yearOfProduction = value.ToString().Trim().Replace(" ", "");
                if (Regex.IsMatch(_yearOfProduction, @"^[0-9]+$")) //TODO : sayı girip girmediğini kontrol etmeliyiz
                {
                    short s_yearOfProduction = Convert.ToInt16(_yearOfProduction);
                    if (s_yearOfProduction < GUN_YEAR_BASE)
                    {
                        yearOfProduction = GUN_YEAR_BASE;

                    }
                    else if (s_yearOfProduction >= DateTime.Now.Year)
                    {
                        yearOfProduction = (short)DateTime.Now.Year;
                    }
                    else
                    {
                        yearOfProduction = s_yearOfProduction;
                    }
                }
                else
                {
                    yearOfProduction = GUN_YEAR_BASE;
                }
            }
        }
        public string Caliber
        {
            get
            {
                return caliber;
            }
            set
            {
                caliber = value;
            }
        }
        public Gun()
        {
        }
        public Gun(string trademark, string trademarkModel, string gunLicense, short yearOfProduction, string caliber)
        {
            Trademark = trademark;
            TrademarkModel = trademarkModel;
            GunLicense = gunLicense;
            YearOfProduction = yearOfProduction;
            Caliber = caliber;
        }
    }
}