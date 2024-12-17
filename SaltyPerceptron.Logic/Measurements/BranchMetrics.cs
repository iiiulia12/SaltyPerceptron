using SaltyPerceptron.Logic.Instruction;

namespace SaltyPerceptron.Logic.Measurements;

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
    
    public void UpdateBranchMetrics(Branch branch, BranchMetrics metrics)
    {
        metrics.TotalBranches++;

        if (branch.ActualTaken)
        {
            metrics.ActualTaken++;
            if (branch.PredictTaken)
            {
                metrics.CorrectPredictions++;
                metrics.TruePositives++;
            }
            else
            {
                metrics.IncorrectPredictions++;
            }
        }
        else
        {
            metrics.ActualNotTaken++;
            if (!branch.PredictTaken)
            {
                metrics.CorrectPredictions++;
                metrics.TrueNegatives++;
            }
            else
            {
                metrics.IncorrectPredictions++;
            }
        }
    }

    public void Reset()
    {
        TotalBranches = 0;
        CorrectPredictions = 0;
        IncorrectPredictions = 0;
        ActualNotTaken = 0;
        ActualTaken = 0;
        TrueNegativeRate = 0;
        TruePositiveRate = 0;
        TruePositives = 0;
        TrueNegatives = 0;
        Accuracy = 0;
        MispredictionRate = 0;
        
    }
}
