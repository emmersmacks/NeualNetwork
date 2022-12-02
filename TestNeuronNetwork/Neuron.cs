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

        public void SetWeights(params double[] weights)
        {
            //TODO: delete after add learning network
            for (int i = 0; i < weights.Length; i++)
            {
                Weights[i] = weights[i];
            }
        }

        private void AddWeights(int inputCount)
        {
            for (int i = 0; i < inputCount; i++)
            {
                Weights.Add(1);
            }
        }

        private double Sigmoid(double x)
        {
            var result = 1.0 / (1.0 + Math.Pow(Math.E, -x));
            return result;
        }
    }
}

