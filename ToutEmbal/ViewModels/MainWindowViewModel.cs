using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace ToutEmbal.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Payments))]
    private int _amountLent;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(NumberPayments))]
    [NotifyPropertyChangedFor(nameof(Payments))]
    private int _duration;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(NumberPayments))]
    [NotifyPropertyChangedFor(nameof(Payments))]
    private int _periodBetweenPayments;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Payments))]
    private int _interests;

    public int NumberPayments => this.Duration / this.PeriodBetweenPayments;
    public double Payments
    {
        get
        {
            float intRate = (float)this.Interests / 100 / (12 / this.PeriodBetweenPayments);

            return this.AmountLent * (intRate / (1 - Math.Pow((1 + intRate), -this.NumberPayments)));
        }
    }

    public MainWindowViewModel()
    {
        this._name = string.Empty;
        this._amountLent = 0;
        this._duration = 1;
        this._interests = 300;
        this._periodBetweenPayments = 1;
    }
}
