namespace TestNeuronNetwork;

public class NeuralNetwork
{
    public Topology Topology { get; }
    public List<Layer> Layers { get; }

    public NeuralNetwork(Topology topology)
    {
        Topology = topology;
        Layers = new List<Layer>();

        CreateInputLayer();
        CreateHiddenLayers();
        CreateOutputLayer();
    }

    public double FeedForward(List<double> inputSignals)
    {
        SendSignalsToInputNeurons(inputSignals);
        for (int i = 1; i < Layers.Count; i++)
        {
            var layer = Layers[i];
        }
    }

    private void SendSignalsToInputNeurons(List<double> inputSignals)
    {
        for (int i = 0; i < inputSignals.Count; i++)
        {
            var signal = new List<double> { inputSignals[i] };
            var neuron = Layers[0].Neurons[i];

            neuron.FeedForward(signal);
        }
    }

    private void CreateHiddenLayers()
    {
        for (int j = 0; j < Topology.HiddenLayers.Count; j++)
        {
            var hiddenNeurons = new List<Neuron>();
            var lastLayer = Layers.Last();
            for (int i = 0; i < Topology.HiddenLayers[j]; i++)
            {
                var neuron = new Neuron(lastLayer.Count);
                hiddenNeurons.Add(neuron);
            }

            var layer = new Layer(hiddenNeurons);
            Layers.Add(layer);
        }
        
    }

    private void CreateOutputLayer()
    {
        var inputNeurons = new List<Neuron>();
        var lastLayer = Layers.Last();
        for (int i = 0; i < Topology.OutputCount; i++)
        {
            var neuron = new Neuron(lastLayer.Count, ENeuronType.Output);
            inputNeurons.Add(neuron);
        }

        var layer = new Layer(inputNeurons, ENeuronType.Output);
        Layers.Add(layer);
    }

    private void CreateInputLayer()
    {
        var inputNeurons = new List<Neuron>();
        for (int i = 0; i < Topology.InputCount; i++)
        {
            var neuron = new Neuron(1, ENeuronType.Input);
            inputNeurons.Add(neuron);
        }

        var layer = new Layer(inputNeurons, ENeuronType.Input);
        Layers.Add(layer);
    }
}