namespace SaltyPerceptron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct CharacterPair
        {
            public char BranchType { get; set; }
            public char Action { get; set; }
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
                List<CharacterPair> characterPairs = ExtractCharacterPairs(filePath);

                foreach (var pair in characterPairs)
                {
                    extractedInfo.Items.Add($"Branch Type - {pair.BranchType} : Action - {pair.Action}");
                }

                MessageBox.Show("Character pairs extracted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private List<CharacterPair> ExtractCharacterPairs(string filePath)
        {
            var pairs = new List<CharacterPair>();

            try
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    if (line.Length >= 2) 
                    {
                        pairs.Add(new CharacterPair
                        {
                            BranchType = line[0],
                            Action = line[1]
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return pairs;
        }
    }
}
