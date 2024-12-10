using SaltyPerceptron.Logic.FileOperations;
using SaltyPerceptron.Logic.Instruction;
using SaltyPerceptron.Logic.Measurements;
using SaltyPerceptron.Logic.Registries;
namespace SaltyPerceptron;

public partial class Form1 : Form
{
    Bootstrapper bootstrapper;
    bool fileLoaded = false;
    public Form1()
    {
        InitializeComponent();
        simulateButton.Visible = false;
        bootstrapper = new Bootstrapper();
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
           bootstrapper.LoadFile(openFileDialog.FileName);
        }
        simulateButton.Visible = fileLoaded;
        MessageBox.Show("Branches extracted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        printBranches(bootstrapper.BranchRegistry.GetAll());
        simulateButton.Visible = true;

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

    private void printMetrics(BranchMetrics metrics)
    {
        lblTotalBranches.Text = $"Total Branches: {metrics.TotalBranches}";
        lblCorrectPredictions.Text = $"Correct Predictions: {metrics.CorrectPredictions}";
        lblIncorrectPredictions.Text = $"Incorrect Predictions: {metrics.IncorrectPredictions}";
        lblAccuracy.Text = $"Accuracy: {metrics.Accuracy:F2}%";
        lblMispredictionRate.Text = $"Misprediction Rate: {metrics.MispredictionRate:F2}%";
        lblTruePositiveRate.Text = $"True Positive Rate: {metrics.TruePositiveRate:F2}%";
        lblTrueNegativeRate.Text = $"True Negative Rate: {metrics.TrueNegativeRate:F2}%";
    }

    private void simulateButton_Click(object sender, EventArgs e)
    {
        int perceptronsCount = (int)perceptronsNrUpDown.Value;
        int hrCount = (int)hrSizeUpDown.Value;
   
       
        bootstrapper.ResetAndInitializeRegistries(perceptronsCount, hrCount);

        bootstrapper.BranchRegistry.GetAll().ForEach(branch =>
        {
            bootstrapper.BranchPredictor.SimulateBranch(branch);
            bootstrapper.BranchMetrics.UpdateBranchMetrics(branch, bootstrapper.BranchMetrics);
            bootstrapper.BranchMetrics.CalculateDerivedMetrics();
        });

        printPredictions(bootstrapper.BranchRegistry.GetAll());
        printMetrics(bootstrapper.BranchMetrics);

    }
}
