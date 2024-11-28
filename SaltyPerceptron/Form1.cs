using SaltyPerceptron.Logic.Instruction;
namespace SaltyPerceptron
{
    public partial class Form1 : Form
    {
        InstructionRegistry instructionRegisty;
        public Form1()
        {
            InitializeComponent();
            instructionRegisty = new InstructionRegistry();

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

                foreach (var ins in instructions)
                {
                    extractedInfo.Items.Add($"Branch Type - {ins.Type.Type} : Action - {ins.Type.Action}");
                }

                MessageBox.Show("Character pairs extracted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExtractCharacterPairs(string filePath)
        {

            try
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    var parts = line.Split(' ');
                    Branch branch = new Branch(parts[0], parts[1], parts[2]);
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
