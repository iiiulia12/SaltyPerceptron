

namespace SaltyPerceptron.Logic.Instruction
{
    public class BranchType
    {
        public Char Type {  get; set; }
        public Char Action {  get; set; }

        public BranchType(string fileLine) 
        {
            this.Type = fileLine[1];
            this.Action = fileLine[0];
           
        }
    }
}
