namespace Wpfcontroles
{
    public class Transaction
    {
        private string nom;
        private DateTime date;
        private decimal montant;
        private string codePostal;

        public string Nom { get => nom; set => nom = value; }
        public DateTime Date
        {
            get => date; set
            {
                date = value;
            }
        }
        public decimal Montant { get => montant; set => montant = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }

        public Transaction(string nom, DateTime date, decimal montant, string codePostal)
        {
            this.nom = nom;
            this.date = date;
            this.montant = montant;
            this.codePostal = codePostal;
        }

        public Transaction() : this("", DateTime.Now, 0, "") { }
    }
}
