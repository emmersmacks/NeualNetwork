using TestNeuronNetwork;

namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var topology = new Topology(4, 1, 2);
        var network = new NeuralNetwork(topology);
        network.Layers[1].Neurons[0].SetWeights(0.5, -0.1, 0.3, -0.1);
        network.Layers[1].Neurons[1].SetWeights(0.1, -0.3, 0.7, -0.3);
        network.Layers[2].Neurons[0].SetWeights(1.2, 0.8);
        var result = network.FeedForward(new List<double> { 1, 0, 0, 0 });
        Console.Write(result);
    }
}