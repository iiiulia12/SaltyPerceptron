
namespace SaltyPerceptron.Logic.Instruction
{
    public class Branch : Instruction
    {
        public BranchType Type {  get; set; }
        public bool Taken { get; set; }
        public bool TakenPredict { get; set; }
        public Branch(String type, String source) : base(source)
        {
            this.Type = new BranchType(type);
            Taken = this.Type.Action == 'B' ? true : false;


        }


    }
}
