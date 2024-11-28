
namespace SaltyPerceptron.Logic.Instruction
{
    public class InstructionRegistry
    {
        private List<Branch> instructions = new List<Branch>();

        public void Add(in Branch instruction)
        {
            if (instruction.Type.Type == 'T' || instruction.Type.Type == 'F')
                instructions.Add(instruction);
        }

        public List<Branch> GetAll ()
        {
            return instructions.ToList();
        }
     
     
    }
}
