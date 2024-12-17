using SaltyPerceptron.Logic.FileOperations;
using SaltyPerceptron.Logic.Measurements;
using SaltyPerceptron.Logic.Registries;

namespace SaltyPerceptron
{
    public class Bootstrapper
    {
        public HRRegistry HRRegistry { get; private set; }
        public PerceptronRegistry PerceptronRegistry { get; private set; }
        public BranchPredictor BranchPredictor { get; private set; }
        public BranchMetrics BranchMetrics { get; private set; }
        public FileParser FileParser { get; private set; }
        public BranchRegistry BranchRegistry { get; private set; }

        public Bootstrapper()
        {
            HRRegistry = new HRRegistry();
            PerceptronRegistry = new PerceptronRegistry();
            BranchMetrics = new BranchMetrics();
            BranchPredictor = new BranchPredictor(HRRegistry, PerceptronRegistry);
        }

        public void LoadFile(string filePath)
        {
            FileParser = new FileParser(filePath);
            FileParser.ParseFile();
            BranchRegistry = new BranchRegistry(FileParser.GetValues());
        }

        public void ResetAndInitializeRegistries(int perceptronsCount, int hrCount)
        {
            HRRegistry.Reset();
            HRRegistry.Initialize(hrCount);
            PerceptronRegistry.Reset();
            PerceptronRegistry.Initialize(perceptronsCount, hrCount);
            BranchMetrics.Reset();
        }
    }
}
