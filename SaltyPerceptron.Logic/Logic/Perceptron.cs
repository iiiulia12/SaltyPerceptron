

namespace SaltyPerceptron.Logic.Logic
{
    internal class Perceptron
    {
        public List<int> WT { get; set; }  
        public List<int> WNT { get; set; }

        public Perceptron(int numWeights)
        {
            WT = Enumerable.Repeat(1, numWeights).ToList();
            WNT = Enumerable.Repeat(-1, numWeights).ToList();
        }

        public int CalculateSum(bool isTaken, List<int> history)
        {
            int sum = 0;

            List<int> weights = isTaken ? WT : WNT;
            weights.Select((weight, index) => sum += weight * history[index]);
  
            return sum;
        }

        public void AdjustWeights(bool realTaken)
        {
            int adjustment = realTaken ? 1 : -1;

            for (int i = 0; i < WT.Count; i++)
            {
                WT[i] += adjustment;
                WNT[i] += adjustment;
            }
        }
    }
}
