namespace EntityModel.Models;

public partial class Loan
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int AmountLent { get; set; }

    public int Duration { get; set; }

    public int PeriodBetweenPayments { get; set; }

    public int Interests { get; set; }
}
