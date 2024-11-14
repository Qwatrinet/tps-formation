
using EntityModel.Models;
using InterfacePersistanceMetier;
using Persistance;

namespace LoanMetier
{
    public partial class LoanModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int AmountLent { get; set; }

        public int Duration { get; set; }

        public int PeriodBetweenPayments { get; set; }

        public int Interests { get; set; }

        public IPersistanceLoan persistanceLoan;


        public LoanModel() : this("", 0, 1, 1, 7, new PersistanceLoan(new LoanDbContext())) { }
        public LoanModel(string name, int amountLent, int duration, int period, int interests, IPersistanceLoan persistanceLoan)
        {
            this.Name = name;
            this.AmountLent = amountLent;
            this.Duration = duration;
            this.PeriodBetweenPayments = period;
            this.Interests = interests;
            this.persistanceLoan = persistanceLoan;
        }

        public LoanModel(StructLoan structLoan, IPersistanceLoan persistanceLoan)
        {
            this.Name = structLoan.name;
            this.AmountLent = structLoan.amountLent;
            this.Duration = structLoan.duration;
            this.PeriodBetweenPayments = structLoan.periodBetweenPayment;
            this.Interests = structLoan.interests;
            this.persistanceLoan = persistanceLoan;
        }

        public LoanModel(LoanModel loan)
        {
            if (loan == null)
            {
                //loan = new Loan();
                throw new ArgumentNullException(nameof(loan));
            }
            this.Name = loan.Name;
            this.AmountLent = loan.AmountLent;
            this.Duration = loan.Duration;
            this.PeriodBetweenPayments = loan.PeriodBetweenPayments;
            this.Interests = loan.Interests;
            this.persistanceLoan = loan.persistanceLoan;
        }

        public int CalcNumberPayments()
        {
            return this.Duration / this.PeriodBetweenPayments;
        }

        public double CalcPayments()
        {
            int numberPayments = CalcNumberPayments();
            float intRate = (float)this.Interests / 100 / (12 / this.PeriodBetweenPayments);

            return this.AmountLent * (intRate / (1 - Math.Pow((1 + intRate), -numberPayments)));
        }

        public void Charger(int id)
        {
            StructLoan structLoan = this.persistanceLoan.Load(id);
            this.Id = structLoan.id;
            this.Name = structLoan.name;
            this.AmountLent = structLoan.amountLent;
            this.Duration = structLoan.duration;
            this.PeriodBetweenPayments = structLoan.periodBetweenPayment;
            this.Interests = structLoan.interests;
        }

        public void Sauvegarder()
        {
            StructLoan structloan = new StructLoan();
            structloan.id = this.Id;
            structloan.name = this.Name;
            structloan.amountLent = this.AmountLent;
            structloan.duration = this.Duration;
            structloan.periodBetweenPayment = this.PeriodBetweenPayments;
            structloan.interests = this.Interests;
            if (this.Id == 0) //création d'une nouvelle entrée
            {
                this.persistanceLoan.Add(structloan);
                return;
            }
            this.persistanceLoan.Update(structloan);
        }
    }
}
