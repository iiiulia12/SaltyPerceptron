

using SaltyPerceptron.Logic.Instruction;
using SaltyPerceptron.Logic.Registries;

namespace SaltyPerceptron.Logic.FileOperations
{
    public class FileParser
    {
        private string filePath;

        public FileParser (string filePath)
        {
            this.filePath = filePath;
        }

        public void ParseFile (BranchRegistry branchRegistry)
        {
            try
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    var parts = line.Split(' ');
                    Branch branch = new(parts[0], parts[1]);
                    branchRegistry.Add(branch);

                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
