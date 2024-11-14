using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace StagiaireLib
{
    public class Stagiaire
    {
        private string nom;
        private string prenom;
        private DateTime dateDebut;
        private DateTime dateFin;
        private Formation formation;

        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public DateTime DateDebut { get => dateDebut; }
        public DateTime DateFin { get => dateFin; }
        public Formation Formation { get => formation; }

        public Stagiaire(string nom, string prenom, DateTime dateDebut, DateTime dateFin, Formation formation)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.formation = formation;
        }

        public static bool ValidateName(string nomAVerifier)
        {
            Regex myRegex = new Regex(@"^[A-Z]{1}[a-zéàùêèôïëç]*(?:-[A-Z]{1}[a-zéàùêèôïëç]*)?$", RegexOptions.Compiled);
            return myRegex.IsMatch(nomAVerifier) && nomAVerifier.Length <= 25;
        }

        public static bool ValidateDate(string date)
        {
            try
            {
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

        public bool ValidateDatesFormation()
        {
            return dateDebut < dateFin && dateDebut > DateTime.Now && dateFin > DateTime.Now;
        }

        public bool ValidateFormation()
        {
            return formation != Formation.Indetermine;
        }

        public string GenNomSection()
        {
            return formation.ToString() + dateDebut.Year.ToString();
        }
    }
}
