using SaltyPerceptron.Logic.Instruction;

namespace SaltyPerceptron.Logic.Registries
{
    public class BranchRegistry
    {
        private List<Branch> instructions = new List<Branch>();

        public BranchRegistry(List<(string, string)> values)
        {
            values.ForEach(x => this.Add(new Branch(x.Item1, x.Item2)));
        }
        public void Add(in Branch instruction)
        {
            if (instruction.Type.Type == 'T' || instruction.Type.Type == 'F')
                instructions.Add(instruction);
        }

        public List<Branch> GetAll()
        {
            return instructions.ToList();
        }

    }
}
