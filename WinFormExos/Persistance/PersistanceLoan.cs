using EntityModel.Models;
using InterfacePersistanceMetier;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class PersistanceLoan : IPersistanceLoan
    {
        private LoanDbContext dbContext;


        public PersistanceLoan(LoanDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        public void Add(StructLoan sClassMetier)
        {
            Loan loan = new Loan();
            loan.Duration = sClassMetier.duration;
            loan.Name = sClassMetier.name;
            loan.AmountLent = sClassMetier.amountLent;
            loan.Interests = sClassMetier.interests;
            loan.PeriodBetweenPayments = sClassMetier.periodBetweenPayment;
            this.dbContext.Loans.Add(loan);
            this.dbContext.SaveChanges();
        }


        public void Update(StructLoan sClassMetier)
        {
            Loan loan = this.dbContext.Loans.Where(l => l.Id == sClassMetier.id).First();
            loan.Duration = sClassMetier.duration;
            loan.Name = sClassMetier.name;
            loan.AmountLent = sClassMetier.amountLent;
            loan.Interests = sClassMetier.interests;
            loan.PeriodBetweenPayments = sClassMetier.periodBetweenPayment;
            this.dbContext.Entry(loan).State = EntityState.Modified;
            this.dbContext.SaveChanges();
        }

        public StructLoan Load(int idToDisplay)
        {

            Loan loan = (this.dbContext.Loans.Where(l => l.Id == idToDisplay).First());
            StructLoan structLoan = new StructLoan();
            structLoan.id = loan.Id;
            structLoan.name = loan.Name;
            structLoan.amountLent = loan.AmountLent;
            structLoan.duration = loan.Duration;
            structLoan.periodBetweenPayment = loan.PeriodBetweenPayments;
            structLoan.interests = loan.Interests;
            return structLoan;


        }


    }
}
