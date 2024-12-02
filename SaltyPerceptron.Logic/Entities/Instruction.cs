
namespace SaltyPerceptron.Logic.Instruction
{
    public class Instruction
    {
        public int PC {  get; set; }
        public Instruction(string PC)
        {
            Console.WriteLine(PC);
            this.PC = int.Parse(PC);
            Console.WriteLine(this.PC + "  PArsed");
        }
    }
}
