using SaltyPerceptron.Logic.Instruction;
namespace SaltyPerceptron
{
    public partial class Form1 : Form
    {
        InstructionRegistry instructionRegisty;
        BranchPredictor branchPredictor;
        public Form1()
        {
            InitializeComponent();
            instructionRegisty = new InstructionRegistry();
            branchPredictor = new BranchPredictor();

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

                foreach (var ins in instructions)
                {
                    extractedInfo.Items.Add($"#{index} - Branch Type - {ins.Type.Type} : Action - {ins.Type.Action} : Taken - {ins.Taken} : Predicted - {ins.TakenPredict}");
                    index++; 
                }

            }
        }
        private void ExtractCharacterPairs(string filePath)
        {

            try
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    var parts = line.Split(' ');
                    Branch branch = new Branch(parts[0], parts[1]);
                    instructionRegisty.Add(branch);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
