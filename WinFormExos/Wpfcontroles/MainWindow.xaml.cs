using System.Globalization;
using System.Windows;

namespace Wpfcontroles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CurrentCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentCulture;

            this.DataContext = new ViewModelTransaction(new Transaction());
            ((ViewModelTransaction)this.DataContext).ErrorsChanged += MainWindow_ErrorsChanged;
        }

        private void MainWindow_ErrorsChanged(object? sender, System.ComponentModel.DataErrorsChangedEventArgs e)
        {
            this.BtnValid.IsEnabled = !((ViewModelTransaction)sender).HasErrors;
        }

        private void BtnValid_Click(object sender, RoutedEventArgs e)
        {

            ValiderWindow validerWindow = new ValiderWindow((ViewModelTransaction)this.DataContext);
            validerWindow.Show();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelTransaction)this.DataContext).ErrorsChanged -= MainWindow_ErrorsChanged;
            this.DataContext = new ViewModelTransaction(new Transaction());
            ((ViewModelTransaction)this.DataContext).ErrorsChanged += MainWindow_ErrorsChanged;
        }
    }
}