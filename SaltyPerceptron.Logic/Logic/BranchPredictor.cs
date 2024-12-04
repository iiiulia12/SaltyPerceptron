using SaltyPerceptron.Logic.Instruction;
using SaltyPerceptron.Logic.Logic;
using SaltyPerceptron.Logic.Registries;

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

        bool isTaken = hrRegistry.GetLastBit() == 1;

        int sum = currentPerceptron.CalculateSum(isTaken, hrRegistry.GetAll());
        bool predictedTaken = sum >= 0;

        currentPerceptron.AdjustWeights( branch.ActualTaken);

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
