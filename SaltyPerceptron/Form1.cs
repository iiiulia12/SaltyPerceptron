using SaltyPerceptron.Logic;
using SaltyPerceptron.Logic.Instruction;
namespace SaltyPerceptron;

public partial class Form1 : Form
{
    InstructionRegistry instructionRegisty;
    BranchPredictor branchPredictor;
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
            instructionRegisty = new InstructionRegistry();
            branchPredictor = new BranchPredictor((int)perceptronsNrUpDown.Value, (int)hrSizeUpDown.Value);

            extractedInfo.Items.Clear();
            string filePath = openFileDialog.FileName;
            ExtractCharacterPairs(filePath);
            List<Branch> instructions = instructionRegisty.GetAll();

            int index = 1;
            foreach (var ins in instructions)
            {
                extractedInfo.Items.Add($"#{index} - Branch Type - {ins.Type.Type} : Action - {ins.Type.Action}");
                index++;
            }

            MessageBox.Show("Character pairs extracted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            instructions.ForEach(branch => branchPredictor.SimulateBranch(branch));

            index = 1;
            extractedInfo.Items.Clear();
            var metrics = new BranchMetrics();

            foreach (var branch in instructions)
            {
                extractedInfo.Items.Add($"#{index} - Branch Type - {branch.Type.Type} : Action - {branch.Type.Action} : Taken - {branch.Taken} : Predicted - {branch.TakenPredict}");
                index++;
                UpdateBranchMetrics(branch, metrics);
                metrics.CalculateDerivedMetrics();
            }

            lblTotalBranches.Text = $"Total Branches: {metrics.TotalBranches}";
            lblCorrectPredictions.Text = $"Correct Predictions: {metrics.CorrectPredictions}";
            lblIncorrectPredictions.Text = $"Incorrect Predictions: {metrics.IncorrectPredictions}";
            lblAccuracy.Text = $"Accuracy: {metrics.Accuracy:F2}%";
            lblMispredictionRate.Text = $"Misprediction Rate: {metrics.MispredictionRate:F2}%";
            lblTruePositiveRate.Text = $"True Positive Rate: {metrics.TruePositiveRate:F2}%";
            lblTrueNegativeRate.Text = $"True Negative Rate: {metrics.TrueNegativeRate:F2}%";

        }
    }
    private void ExtractCharacterPairs(string filePath)
    {

        try
        {
            foreach (var line in File.ReadLines(filePath))
            {
                var parts = line.Split(' ');
                Branch branch = new(parts[0], parts[1]);
                instructionRegisty.Add(branch);

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void UpdateBranchMetrics(Branch branch, BranchMetrics metrics)
    {
        metrics.TotalBranches++;

        if (branch.Taken)
        {
            metrics.ActualTaken++;
            if (branch.TakenPredict)
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
            if (!branch.TakenPredict)
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


}
