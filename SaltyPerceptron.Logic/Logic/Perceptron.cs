

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

        public int CalculateSum(List<int> history)
        {
            int sum = 0;

            for (int i = 0; i < history.Count; i++)
            {
                if (history[i] == 1)
                {
                    sum += WT[i];
                }
                else
                {
                    sum += WNT[i];
                }
            }

            return sum;
        }

        public void AdjustWeights(bool realTaken, List<int> history)
        {
            int current = realTaken ? 1 : -1;

            for (int i = 0; i < history.Count; i++)
            {
                if (current == 1 && history[i] == 1)
                    WT[i]++;

                if (current == 1 && history[i] == -1)
                    WNT[i]++;

                if (current == -1 && history[i] == 1)
                    WT[i]--;

                if (current == -1 && history[i] == -1)
                    WNT[i]--;
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
