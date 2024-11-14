using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Wpfcontroles
{
    public class ViewModelTransaction : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private Transaction transaction;

        public ViewModelTransaction(Transaction transaction)
        {
            this.transaction = transaction;
        }

        public string Nom
        {
            get
            {
                ValidateUserName(transaction.Nom);
                return transaction.Nom;
            }
            set
            {
                transaction.Nom = value;
                ValidateUserName(transaction.Nom);
                this.OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get
            {
                ValidateDate(transaction.Date);
                return transaction.Date;
            }
            set
            {
                if (transaction.Date == value)
                {
                    return;
                }

                transaction.Date = value;
                ValidateDate(transaction.Date);
                this.OnPropertyChanged();
            }
        }

        public decimal Montant
        {
            get
            {
                ValidateMontant(transaction.Montant);
                return transaction.Montant;
            }
            set
            {
                transaction.Montant = value;
                ValidateMontant(value);
                this.OnPropertyChanged();
            }
        }

        public string CodePostal
        {
            get
            {
                ValidateCodePostal(transaction.CodePostal);
                return transaction.CodePostal;
            }
            set
            {
                transaction.CodePostal = value;
                ValidateCodePostal(value);
                this.OnPropertyChanged();
            }
        }




        public event PropertyChangedEventHandler? PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string name = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private readonly Dictionary<string, List<string>> _errorsByPropertyName = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> ErrorsByPropertyName
        {
            get
            {
                OnPropertyChanged(nameof(HasErrors));

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

        private void ValidateUserName(string texte)
        {
            ClearErrors(nameof(Nom));
            if (string.IsNullOrWhiteSpace(texte))
            {
                AddError(nameof(Nom), "Le nom ne doit pas être vide.");
                return;
            }

            Regex myRegex = new Regex(@"^[A-Z]{1}[a-zéàùêèôïëç]*(?:-[A-Z]{1}[a-zéàùêèôïëç]*)?$", RegexOptions.Compiled);
            if (!myRegex.IsMatch(texte))
            {
                AddError(nameof(Nom), "Le nom doit être de type Jean-Truite.");
            }
            if (texte.Length >= 30)
            {
                AddError(nameof(Nom), "Votre nom est trop long, raccourcissez-le!");
            }

        }


        private void ValidateDate(DateTime? date)
        {
            ClearErrors(nameof(Date));
            if (date == null)
            {
                AddError(nameof(Date), "Saisissez une date.");
                return;
            }
            if (date <= DateTime.Now)
            {
                AddError(nameof(Date), "Fraude détectée! Vous êtes viré(e)!");
            }

        }

        private void ValidateMontant(decimal montant)
        {
            ClearErrors(nameof(Montant));
            if (montant == null)
            {
                AddError(nameof(Montant), "Saisissez un montant.");
                return;
            }
            if (montant <= 0)
            {
                AddError(nameof(Montant), "Le montant doit être supérieur à zéro.");
            }
            if (montant > 10000)
            {
                AddError(nameof(Montant), "Veuillez contacter votre conseiller pour transférer un tel montant.");
            }

        }

        private void ValidateCodePostal(string code)
        {
            ClearErrors(nameof(CodePostal));
            Regex myRegex = new Regex("^[0-9]{5}$");
            if (code == null)
            {
                AddError(nameof(CodePostal), "Saisissez un code postal.");
                return;
            }
            if (!myRegex.IsMatch(code))
            {
                AddError(nameof(CodePostal), "Le code postal doit être de type 12345.");
            }

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
    }
}
