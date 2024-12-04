

using SaltyPerceptron.Logic.Instruction;
using SaltyPerceptron.Logic.Registries;

namespace SaltyPerceptron.Logic.FileOperations
{
    public class FileParser
    {
        private string filePath;
        private List <(string, string)> values = new List <(string, string)> ();

        public FileParser (string filePath)
        {
            this.filePath = filePath;
        }

        public void ParseFile ()
        {
            try
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    var parts = line.Split(' ');
                    values.Add((parts[0], parts[1]));
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<(string, string)> GetValues()
        {
            return values.ToList();
        }
    }
}
