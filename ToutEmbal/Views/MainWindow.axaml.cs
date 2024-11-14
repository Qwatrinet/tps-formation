using Avalonia.Controls;
using ToutEmbal.ViewModels;

namespace ToutEmbal.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        this.DataContext = new MainWindowViewModel();
    }
}