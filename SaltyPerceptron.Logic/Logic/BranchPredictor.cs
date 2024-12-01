using SaltyPerceptron.Logic.Instruction;
using SaltyPerceptron.Logic.Logic;

public class BranchPredictor
{
    private Perceptron[] perceptrons;
    private HRRegistry hrRegistry;
    private int numPerceptrons;

    public BranchPredictor(int numPerceptrons, int hrSize)
    {
        this.numPerceptrons = numPerceptrons;
        perceptrons = new Perceptron[numPerceptrons];

        for (int i = 0; i < numPerceptrons; i++)
        {
            perceptrons[i] = new Perceptron(10); 
        }

        hrRegistry = new HRRegistry(hrSize); 
    }


    public void SimulateBranch(Branch branch)
    {
        int index = branch.PC % numPerceptrons;  
        Perceptron currentPerceptron = perceptrons[index];

        bool isTaken = hrRegistry.GetBit(index) == 1;

        int sum = currentPerceptron.CalculateSum(isTaken);
        bool predictedTaken = sum >= 0;

        //currentPerceptron.AdjustWeights(isTaken, branch.Taken);
        currentPerceptron.AdjustWeights(branch.Taken);


        hrRegistry.UpdateHistory(branch.Taken ? 1 : -1);
        branch.TakenPredict = predictedTaken;
    }
}
