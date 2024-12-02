
namespace SaltyPerceptron.Logic.Instruction
{
    public class Branch : Instruction
    {
        public BranchType Type {  get; set; }
        public bool ActualTaken { get; set; }
        public bool PredictTaken { get; set; }
        public Branch(String type, String source) : base(source)
        {
            this.Type = new BranchType(type);
            ActualTaken = this.Type.Action == 'B' ? true : false;


        }


    }
}
