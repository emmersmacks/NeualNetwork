namespace TestNeuronNetwork
{
    public class Neuron
    {
        public List<double> Weights { get; }
        public ENeuronType Type { get; }
        public double Output { get; private set; }

        public Neuron(int inputCount, ENeuronType type = ENeuronType.Normal)
        {
            Type = type;
            Weights = new List<double>(inputCount);

            AddWeights(inputCount);
        }

        public double FeedForward(List<double> inputs)
        {
            var sum = 0.0;
            for (int i = 0; i < inputs.Count; i++)
            {
                sum += inputs[i] * Weights[i];
            }

            Output = Sigmoid(sum);
            return Output;
        }

        private void AddWeights(int inputCount)
        {
            for (int i = 0; i < inputCount; i++)
            {
                Weights.Add(i);
            }
        }

        private double Sigmoid(double x)
        {
            var result = 1.0 / (1.0 + Math.Pow(Math.E, -x));
            return result;
        }
    }
}

