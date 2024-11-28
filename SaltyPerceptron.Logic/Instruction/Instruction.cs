
namespace SaltyPerceptron.Logic.Instruction
{
    public class Instruction
    {
        public int PC {  get; set; }
        public Instruction(string PC)
        {
            this.PC = int.Parse(PC);
        }
    }
}
