using EmpruntsLeRetour.EmpruntsViewModel;
using LoanMetier;
using System.Diagnostics;
using System.Windows;


namespace EmpruntsLeRetour
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoanModel loan = new LoanModel();
            //loan.Charger(2);
            this.DataContext = new EmpruntViewModel(loan);


            //this.DataContext = new EmpruntViewModel(dbContext.Loans.First(), dbContext);
        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            if (this.HasAnyError())
            {
                Debug.WriteLine("Error");
            }
            ((EmpruntViewModel)this.DataContext).Persist();
            this.Close();

        }

        private bool HasAnyError()
        {
            return !int.TryParse(textBoxCapital.Text, out _) || ((EmpruntViewModel)this.DataContext).HasErrors;
        }

        private void textBoxCapital_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            this.buttonOK.IsEnabled = !this.HasAnyError();
        }

        private void textBoxNom_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            this.buttonOK.IsEnabled = !this.HasAnyError();
        }
    }
}