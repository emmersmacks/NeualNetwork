namespace TestNeuronNetwork;

public class Topology
{
    public int InputCount { get; }
    public int OutputCount { get; }
    public List<int> HiddenLayers { get; }

    public Topology(int inputCount, int outputCount, params int[] layers)
    {
        InputCount = inputCount;
        OutputCount = outputCount;
        HiddenLayers = layers.ToList();
    }
}