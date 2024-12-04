using SaltyPerceptron.Logic.FileOperations;
using SaltyPerceptron.Logic.Instruction;
using SaltyPerceptron.Logic.Measurements;
using SaltyPerceptron.Logic.Registries;
namespace SaltyPerceptron;

public partial class Form1 : Form
{
    BranchRegistry branchRegistry;
    BranchPredictor branchPredictor;
    FileParser fileParser;
    HRRegistry hrRegistry;
    PerceptronRegistry perceptronRegistry;
    BranchMetrics branchMetrics;
    bool fileLoaded = false;
    public Form1()
    {
        InitializeComponent();
        simulateButton.Visible = false;
        hrRegistry = new HRRegistry();
        perceptronRegistry = new PerceptronRegistry();
        branchPredictor = new BranchPredictor(hrRegistry, perceptronRegistry);
        branchMetrics = new BranchMetrics();

    }

    private void AddFileButton_Click(object sender, EventArgs e)
    {

        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "TRA files (*.tra)|*.tra|All files (*.*)|*.*",
            Title = "Open TRA File"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            fileParser = new FileParser(openFileDialog.FileName);
            fileParser.ParseFile();
            fileLoaded = true;
        }
        simulateButton.Visible = fileLoaded;
        branchRegistry = new BranchRegistry(fileParser.GetValues());
        MessageBox.Show("Branches extracted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        printBranches(branchRegistry.GetAll());

    }

    private void printBranches(List<Branch> branches)
    {
        extractedBranches.Items.Clear();
        List<string> branchesList = new List<string>();

        int index = 1;
        foreach (var branch in branches)
        {
            branchesList.Add($"#{index} - Branch Type - {branch.Type.Type} : Action - {branch.Type.Action}");
            index++;
        }
        extractedBranches.Items.AddRange(branchesList.ToArray());

    }

    private int predictBranches(BranchRegistry branches)
    {
        List<Branch> branches1 = branches.GetAll();
        int sumPredict = branches1.Sum(b => b.PredictTaken ? 1 : 0);
        return sumPredict;
    }
    private int takenBrances(BranchRegistry branches)
    {
        List<Branch> branches1 = branches.GetAll();
        int sum = branches1.Sum(b => b.ActualTaken ? 1 : 0);
        return sum;
    }

    private void printPredictions(List<Branch> branches)
    {
        predictions.Items.Clear();
        List<string> predictionsList = new List<string>();

        int index = 1;
        foreach (var branch in branches)
        {
            string prediction = $"#{index} - Predicted - {branch.PredictTaken} : Actual - {branch.ActualTaken} ";
            predictionsList.Add(prediction);
            index++;
        }
        predictions.Items.AddRange(predictionsList.ToArray());

        int realtaken = takenBrances(branchRegistry);
        int predictTaken = predictBranches(branchRegistry);
        int total = index;
        MessageBox.Show(realtaken.ToString() + "real taken" + predictTaken.ToString() + " predict taken");

    }

    private void printMetrics(BranchMetrics metrics)
    {
        Console.WriteLine(metrics.Accuracy);
        lblTotalBranches.Text = $"Total Branches: {metrics.TotalBranches}";
        lblCorrectPredictions.Text = $"Correct Predictions: {metrics.CorrectPredictions}";
        lblIncorrectPredictions.Text = $"Incorrect Predictions: {metrics.IncorrectPredictions}";
        lblAccuracy.Text = $"Accuracy: {metrics.Accuracy}%";
        lblMispredictionRate.Text = $"Misprediction Rate: {metrics.MispredictionRate}%";
        lblTruePositiveRate.Text = $"True Positive Rate: {metrics.TruePositiveRate:F2}%";
        lblTrueNegativeRate.Text = $"True Negative Rate: {metrics.TrueNegativeRate:F2}%";
    }

    private void simulateButton_Click(object sender, EventArgs e)
    {
        int perceptronsCount = (int)perceptronsNrUpDown.Value;
        int hrCount = (int)hrSizeUpDown.Value;
   
        hrRegistry.Reset();
        hrRegistry.Initialize(hrCount);
        perceptronRegistry.Reset();
        perceptronRegistry.Initialize(perceptronsCount, hrCount);
 


            branchRegistry.GetAll().ForEach(branch =>
            {
                branchPredictor.SimulateBranch(branch);
                branchMetrics.UpdateBranchMetrics(branch, branchMetrics);
                branchMetrics.CalculateDerivedMetrics();
            });

            printPredictions(branchRegistry.GetAll());
            printMetrics(branchMetrics);
        
    }
}
