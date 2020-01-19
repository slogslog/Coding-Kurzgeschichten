package at.htldonaustadt.slog;

import at.htldonaustadt.neuralnetwork.Perceptron;

public class Main {

    public static void main(String[] args) {

        int[][] x =  {
                { 0, 0 },
                { 0, 1 },
                { 1, 0 },
                { 1, 1 }
        };

        double[] desiredOutputs =  {
                0,
                1,
                1,
                0
        };

        Perceptron neuron = new Perceptron(2, 0.5);

        neuron.train(10000, x, desiredOutputs);

        double accuracy = neuron.test(x, desiredOutputs);
        System.out.printf("Genauigkeit = %.0f %%\n", accuracy*100);
    }
}
