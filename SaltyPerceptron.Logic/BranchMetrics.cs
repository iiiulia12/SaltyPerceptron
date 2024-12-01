namespace SaltyPerceptron.Logic;

public class BranchMetrics
{
    public int TotalBranches { get; set; }
    public int CorrectPredictions { get; set; }
    public int IncorrectPredictions { get; set; }
    public int ActualTaken { get; set; }
    public int ActualNotTaken { get; set; }
    public int TruePositives { get; set; }
    public int TrueNegatives { get; set; }

    public double Accuracy { get; private set; }
    public double MispredictionRate { get; private set; }
    public double TruePositiveRate { get; private set; }
    public double TrueNegativeRate { get; private set; }

    public void CalculateDerivedMetrics()
    {
        Accuracy = TotalBranches > 0
            ? (double)CorrectPredictions / TotalBranches * 100
            : 0;

        MispredictionRate = TotalBranches > 0
            ? (double)IncorrectPredictions / TotalBranches * 100
            : 0;

        TruePositiveRate = ActualTaken > 0
            ? (double)TruePositives / ActualTaken * 100
            : 0;

        TrueNegativeRate = ActualNotTaken > 0
            ? (double)TrueNegatives / ActualNotTaken * 100
            : 0;
    }
}
