
using SaltyPerceptron.Logic.Instruction;
using System.Collections;

namespace SaltyPerceptron.Logic.Logic
{
    public class HRRegistry
    {
        private List<int> HR;
        private int size;

        public HRRegistry(int size = 5)
        {
            this.size = size;
            HR = Enumerable.Repeat(-1, size).ToList();
        }

        public List<int> GetAll()
        {
            return HR.ToList();
        }
        private void shift ()
        {
            for (int i = 0; i < size - 1; i++)
            {
                HR[i] = HR[i + 1];
            }
        }

        public int GetLastBit()
        {
            return HR[size-1];
        }
        public void UpdateHistory(int result)
        {
            shift();

            HR[size-1] = result;    
        }
    }
}
