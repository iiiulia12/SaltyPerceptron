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
    public Form1()
    {
        InitializeComponent();
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
            int perceptronsCount = (int)perceptronsNrUpDown.Value;
            int hrCount = (int)hrSizeUpDown.Value;

            hrRegistry = new HRRegistry(hrCount);
            perceptronRegistry = new PerceptronRegistry(perceptronsCount, hrCount);
            branchRegistry = new BranchRegistry();
            branchPredictor = new BranchPredictor(hrRegistry, perceptronRegistry);
            fileParser = new FileParser(openFileDialog.FileName);
            fileParser.ParseFile(branchRegistry);
            var metrics = new BranchMetrics();

            List<Branch> branches = branchRegistry.GetAll();

            printBranches(branches);
            MessageBox.Show("Branches extracted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            branches.ForEach(branch =>
            {
                branchPredictor.SimulateBranch(branch);
                metrics.UpdateBranchMetrics(branch, metrics);
                metrics.CalculateDerivedMetrics();
            });

            printPredictions(branches);
            printMetrics(metrics);
        }
    }

    private void printBranches(List<Branch> branches)
    {
        extractedBranches.Items.Clear();
        List<string> branchesList = new List<string>();

        int index = 1;
        foreach (var branch in branches)
        {
            branchesList.Add($"#{index} - Branch Type - {branch.Type.Type} : Action - {branch.Type.Action}" );
            index++;
        }
        extractedBranches.Items.AddRange(branchesList.ToArray());

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

    }

    private void printMetrics ( BranchMetrics metrics )
    {
        lblTotalBranches.Text = $"Total Branches: {metrics.TotalBranches}";
        lblCorrectPredictions.Text = $"Correct Predictions: {metrics.CorrectPredictions}";
        lblIncorrectPredictions.Text = $"Incorrect Predictions: {metrics.IncorrectPredictions}";
        lblAccuracy.Text = $"Accuracy: {metrics.Accuracy}%";
        lblMispredictionRate.Text = $"Misprediction Rate: {metrics.MispredictionRate}%";
        lblTruePositiveRate.Text = $"True Positive Rate: {metrics.TruePositiveRate:F2}%";
        lblTrueNegativeRate.Text = $"True Negative Rate: {metrics.TrueNegativeRate:F2}%";
    }

}
