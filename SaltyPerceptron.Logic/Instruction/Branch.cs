
namespace SaltyPerceptron.Logic.Instruction
{
    public class Branch : Instruction
    {
        public BranchType Type {  get; set; }
        public String Destination { get; set; }

        public Branch(String type, String source,String destination) : base(source)
        {
            this.Type = new BranchType(type);
            this.Destination = destination;

        }


    }
}
