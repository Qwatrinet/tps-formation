using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace FormControlClass
{
    public static class TransactionCheck
    {

        static public bool CheckNomValide(string nom)
        {
            Regex myRegex = new Regex(@"^[A-Z]{1}[a-zéàùêèôïëç]*(?:-[A-Z]{1}[a-zéàùêèôïëç]*)?$", RegexOptions.Compiled);
            return myRegex.IsMatch(nom) && nom.Length <= 30;

        }

        static public bool CheckDateValide(string date)
        {
            try
            {
                //utilser le TryParseExc
                //"dd/MM/yyyy"
                DateTime dateTocheck = DateTime.ParseExact(date, DateTimeFormatInfo.CurrentInfo.ShortDatePattern, CultureInfo.CurrentCulture);
                if (dateTocheck < DateTime.Now)
                {
                    return false;
                }
                return true;
            }
            catch (FormatException)
            {
                return false;
            }

        }

        static public bool CheckMontantValide(string montant)
        {
            //Regex myRegex = new Regex(@"^[0-9]+(?:[.,][0-9]+)?$");
            return double.TryParse(montant, out double _);
        }
        static public bool CheckIntValid(string amount)
        {
            return int.TryParse(amount, out int value) && value > 0 && amount.Length <= 10;
        }

        static public bool CheckCodePostalValide(string codePostal)
        {
            Regex myRegex = new Regex("^[0-9]{5}$");
            return myRegex.IsMatch(codePostal);

        }
    }
}
