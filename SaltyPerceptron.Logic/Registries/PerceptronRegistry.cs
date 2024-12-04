using SaltyPerceptron.Logic.Logic;
using System.Drawing;

namespace SaltyPerceptron.Logic.Registries
{
    public class PerceptronRegistry
    {
        private List<Perceptron> perceptrons = new List<Perceptron>();
        private int size = 0;
        private int theta;

        public List<Perceptron> GetAll()
        {
            return perceptrons.ToList();
        }

        public Perceptron GetByIndex(int index)
        {
            return perceptrons[index];
        }
        public int GetPerceptronCount()
        {
            return size;
        }

        public void Reset()
        {
            this.size = 0;
            this.perceptrons.Clear();
        }

        public void Initialize(int size, int hrSize)
        {
            perceptrons = Enumerable.Range(0, size)
                         .Select(_ => new Perceptron(hrSize, theta))
                         .ToList();
            this.size = size;
            this.theta = (int)Math.Floor(hrSize * 1.93 + 14);

        }
    }
}
