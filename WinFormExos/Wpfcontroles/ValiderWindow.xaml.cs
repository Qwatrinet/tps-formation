using System.Windows;
namespace Wpfcontroles
{
    /// <summary>
    /// Logique d'interaction pour ValiderWindow.xaml
    /// </summary>
    public partial class ValiderWindow : Window
    {
        public ValiderWindow()
        {
            InitializeComponent();

            this.DataContext = new Transaction
            {
                Nom = "",
                Date = DateTime.Now,
                Montant = 0,
                CodePostal = ""
            };
        }

        public ValiderWindow(ViewModelTransaction datacontext)
        {
            InitializeComponent();

            this.DataContext = datacontext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
