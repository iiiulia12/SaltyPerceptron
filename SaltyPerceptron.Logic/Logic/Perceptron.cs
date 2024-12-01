

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

        public int CalculateSum(bool isTaken)
        {
            List<int> weights = isTaken ? WT : WNT;
            return weights.Sum();
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
