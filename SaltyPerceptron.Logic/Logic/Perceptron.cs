

namespace SaltyPerceptron.Logic.Logic
{
    public class Perceptron
    {
        public List<int> WT { get; set; }  
        public List<int> WNT { get; set; }

        private int theta;
        public Perceptron(int numWeights, int theta)
        {
            WT = Enumerable.Repeat(1, numWeights).ToList();
            WNT = Enumerable.Repeat(-1, numWeights).ToList();
            this.theta = theta;

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
                if (WT[i] > theta  || WNT[i] < theta) break;

                 WT[i] += adjustment;
                 WNT[i] += adjustment;
            }
        }
        //public void AdjustWeights(bool isTaken, bool realTaken)
        //{
        //    if (isTaken == realTaken)
        //    {
        //        if (isTaken)
        //        {
        //            for (int i = 0; i < WT.Count; i++) WT[i]++;
        //        }
        //        else
        //        {
        //            for (int i = 0; i < WNT.Count; i++) WNT[i]++;
        //        }
        //    }
        //    else
        //    {

        //        if (isTaken)
        //        {
        //            for (int i = 0; i < WT.Count; i++) WT[i]--;
        //        }
        //        else
        //        {
        //            for (int i = 0; i < WNT.Count; i++) WNT[i]--;
        //        }
        //    }
        //}
    }
}
