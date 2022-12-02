namespace TestNeuronNetwork;

public class Layer
{
    public List<Neuron> Neurons { get; }
    public int Count => Neurons?.Count ?? 0;

    public Layer(List<Neuron> neurons, ENeuronType type = ENeuronType.Normal)
    {
        //TODO: add neurons check on identity

        Neurons = neurons;
    }
}