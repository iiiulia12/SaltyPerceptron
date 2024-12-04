using SaltyPerceptron.Logic.Instruction;
using SaltyPerceptron.Logic.Logic;
using SaltyPerceptron.Logic.Registries;
using System.Diagnostics;

public class BranchPredictor
{
    private HRRegistry hrRegistry;
    private PerceptronRegistry perceptronRegistry;

    public BranchPredictor(HRRegistry hrRegistry, PerceptronRegistry perceptronRegistry)
    {
        this.perceptronRegistry = perceptronRegistry;
        this.hrRegistry = hrRegistry;
    }

    public void SimulateBranch(Branch branch)
    {
        int index = branch.PC % perceptronRegistry.GetPerceptronCount();
        
        Perceptron currentPerceptron = perceptronRegistry.GetByIndex(index);

        int sum = currentPerceptron.CalculateSum(hrRegistry.GetAll());
        bool predictedTaken = sum >= 0;

        Debug.WriteLine($"index = {index} | sum = {sum}");

        List<int> hrg = hrRegistry.GetAll();
        currentPerceptron.AdjustWeights(branch.ActualTaken, hrg);

        hrRegistry.UpdateHistory(branch.ActualTaken ? 1 : -1);
        branch.PredictTaken = predictedTaken;
    }

    public void Reset()
    {
        hrRegistry.Reset();
        perceptronRegistry?.Reset();
        hrRegistry = null;
        perceptronRegistry = null; 
    }
}
