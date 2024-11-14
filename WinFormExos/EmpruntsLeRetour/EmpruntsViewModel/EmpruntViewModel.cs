using LoanMetier;
using System.Collections;
using System.ComponentModel;
using System.Text.RegularExpressions;
using WpfLibraryBase;

namespace EmpruntsLeRetour.EmpruntsViewModel
{
    public class EmpruntViewModel : BaseViewModel, INotifyDataErrorInfo
    {
        private LoanModel loan;

        public EmpruntViewModel(LoanModel loan)
        {
            this.loan = loan;
            ValidateName(Name);
            ValidateMontant(AmountLent);
        }

        public string Name
        {
            get => loan.Name; set
            {
                loan.Name = value;
                ValidateName(value);
                this.OnPropertyChanged();
            }
        }
        public int AmountLent
        {
            get => loan.AmountLent; set
            {
                ValidateMontant(value);
                loan.AmountLent = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(Payments));


            }
        }
        public int Duration
        {
            get => loan.Duration; set
            {

                loan.Duration = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(NumberPayments));
                this.OnPropertyChanged(nameof(Payments));
            }
        }

        public int PeriodBetweenPayments
        {
            get => loan.PeriodBetweenPayments; set
            {

                loan.PeriodBetweenPayments = value;
                if (loan.Duration < loan.PeriodBetweenPayments)
                {
                    this.Duration = loan.PeriodBetweenPayments;
                }
                else
                {
                    this.Duration -= this.Duration % loan.PeriodBetweenPayments;
                }


                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(NumberPayments));
                this.OnPropertyChanged(nameof(Payments));
            }
        }
        public int Interests
        {
            get => loan.Interests; set
            {

                loan.Interests = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(Payments));
            }
        }

        public int NumberPayments => this.loan.CalcNumberPayments();
        public double Payments => this.loan.CalcPayments();


        //error management

        private readonly Dictionary<string, List<string>> _errorsByPropertyName = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> ErrorsByPropertyName
        {
            get
            {
                //OnPropertyChanged(nameof(HasErrors));

                return _errorsByPropertyName;
            }
        }


        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public IEnumerable GetErrors(string? propertyName)
        {
            return ErrorsByPropertyName.ContainsKey(propertyName!) ?
                         ErrorsByPropertyName[propertyName!] : null!;
        }
        public bool HasErrors
        {
            get => _errorsByPropertyName.Any();
        }


        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        private void AddError(string propertyName, string error)
        {
            if (!_errorsByPropertyName.ContainsKey(propertyName))
                _errorsByPropertyName[propertyName] = new List<string>();

            if (!_errorsByPropertyName[propertyName].Contains(error))
            {
                _errorsByPropertyName[propertyName].Add(error);
                OnErrorsChanged(propertyName);
            }
        }

        private void ClearErrors(string propertyName)
        {
            if (_errorsByPropertyName.ContainsKey(propertyName))
            {
                _errorsByPropertyName.Remove(propertyName);
                OnErrorsChanged(propertyName);
            }
        }

        private void ValidateName(string name)
        {
            ClearErrors(nameof(Name));
            if (string.IsNullOrWhiteSpace(name))
            {
                AddError(nameof(Name), "Le nom ne doit pas être vide.");
                return;
            }

            Regex myRegex = new Regex(@"^[A-Z]{1}[a-zéàùêèôïëç]*(?:-[A-Z]{1}[a-zéàùêèôïëç]*)?$", RegexOptions.Compiled);
            if (!myRegex.IsMatch(name))
            {
                AddError(nameof(Name), "Le nom doit être de type Jean-Truite.");
            }
            if (name.Length >= 30)
            {
                AddError(nameof(Name), "Votre nom est trop long, raccourcissez-le!");
            }
        }

        private void ValidateMontant(decimal montant)
        {
            ClearErrors(nameof(AmountLent));
            if (montant <= 0)
            {
                AddError(nameof(AmountLent), "Le montant doit être supérieur à zéro.");
            }
            if (montant > 500000)
            {
                AddError(nameof(AmountLent), "Vous êtes trop pauvre pour qu'on vous prête une telle somme. Dégagez!");
            }

        }

        public void Persist()
        {
            this.loan.Sauvegarder();
        }

    }
}
