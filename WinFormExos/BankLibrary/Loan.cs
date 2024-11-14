using System;

namespace BankLibrary
{
    public class Loan
    {
        private string name;
        private int amountLent;
        private int duration;
        private int periodBetweenPayments;
        private int interests;

        public string Name { get => name; set => name = value; }
        public int AmountLent { get => amountLent; set => amountLent = value; }
        public int Duration { get => duration; set => duration = value; }
        public int PeriodBetweenPayments { get => periodBetweenPayments; set => periodBetweenPayments = value; }
        public int Interests { get => interests; set => interests = value; }

        public Loan() : this("", 0, 1, 1, 7) { }
        public Loan(string name, int amountLent, int duration, int period, int interests)
        {
            this.name = name;
            this.amountLent = amountLent;
            this.duration = duration;
            this.periodBetweenPayments = period;
            this.interests = interests;
        }

        public Loan(Loan loan)
        {
            if (loan == null)
            {
                //loan = new Loan();
                throw new ArgumentNullException(nameof(loan));
            }
            this.name = loan.Name;
            this.amountLent = loan.AmountLent;
            this.duration = loan.Duration;
            this.periodBetweenPayments = loan.PeriodBetweenPayments;
            this.interests = loan.Interests;
        }

        public int CalcNumberPayments()
        {
            return this.duration / this.periodBetweenPayments;
        }

        public double CalcPayments()
        {
            int numberPayments = CalcNumberPayments();
            float intRate = (float)this.interests / 100 / (12 / this.periodBetweenPayments);

            return this.amountLent * (intRate / (1 - Math.Pow((1 + intRate), -numberPayments)));
        }

    }
}
