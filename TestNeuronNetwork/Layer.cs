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

    public List<double> GetSignals()
    {
        var result = new List<double>();
        foreach (var neuron in Neurons)
        {
            result.Add(neuron.Output);
        }

        return result;
    }
}