package at.htldonaustadt.neuralnetwork;

import java.util.Random;

public class Perceptron {

    private final int N;        // Anzahl der Inputs (mit 1 für w0)
    private double[] weights;   // Gewichte
    private double rate;        // Lernrate: Wie stark wird auf einen Fehler reagiert.

    public Perceptron(int n, double rate) {
        N = n+1;
        weights = new double[N];
        this.rate = rate;
    }

    // Summe berechnen
    private double getSum(int[] x) {
        double sum = 0;

        for ( int i = 0; i < N; i++ )
            sum += x[i] * weights[i];

        return sum;
    }

    // Aktivierungsfunktion: Logistische Funktion (Sigmoid)
    private double activation(double sum) {
        return 1./(1.+Math.exp(-sum));
    }

    // Output des Neurons berechnen
    private double getOutput(int[] x)  {
        double sum = getSum(x);
        return activation(sum);
    }

    public double test(int[][] _x, double[] y) {
        int[][] x = createArrayWith1InFirstColumn(_x);

        writeHeaderLine();

        int counter = 0;

        for ( int i = 0; i < x.length; i++ ) {
            double output = getOutputPrint(x[i]);

            if ( is1(output) == is1(y[i]) ) {
                counter++;
                System.out.println("  Ok");
            }
            else
                System.out.println("  Falsch!");
        }

        return (double)counter/y.length;
    }

    private static boolean is1( double value ) {
        return value > 0.5;
    }

    // aktualisiert die Gewichte
    private void update(int[] x, double outDesired, double outputReal) {
        double error = outDesired-outputReal;

        for ( int i = 0; i < N; i++ ) {
            double delta_wi = error*x[i]*rate*outputReal*(1-outputReal); // Gewichtsanpassung
            weights[i] += delta_wi;
        }
    }

    // Trainiert das Neuron für Inputs x auf die gewünschten Outputs
    public void train(int epochs, int[][] _x, double[] output) {
        int[][] x = createArrayWith1InFirstColumn(_x);

        setRandomWeights();

        System.out.println("Zufällige Gewichte:");
        printWeights();
        System.out.println();

        System.out.println("Training:");
        for ( int e = 0; e < epochs; e++ ) {
            System.out.printf("%d) ", e+1);

            int sample = rnd.nextInt(x.length);
            int[] xi = x[sample]; // one of the combinations
            writeInputs(xi);
            double outputDesired = output[sample];

            double outputReal = getOutput(xi);
            if( outputDesired != outputReal ) {
                System.out.printf(" -> Output %f statt %f\n", outputReal, outputDesired);
                update(xi, outputDesired, outputReal);
                printWeights();
                System.out.println();
            }
            else
                System.out.println(" -> Ok");
        }
    }

    // Gibt eine Zeile mit der Berechnung aus, ob der output den gewünschten Wert hat.
    private double getOutputPrint(int[] x) {

        double sum = 0;

        for ( int i = 0; i < N; i++ ) {
            sum += x[i] * weights[i];
            System.out.printf("%d * %9.6f ", x[i], weights[i], x[i] * weights[i]);

            if ( i != N-1 )
                System.out.print("+ ");
        }

        System.out.printf("= %9.6f", sum);

        double output = activation(sum);
        System.out.printf("   -> %f", output);
        return output;
    }

    private static Random rnd = new Random();

    // Setzt die Gewichte zufällig auf: -1 < Gewicht < +1
    public void setRandomWeights() {
        for ( int i = 0; i < N; i++ ) {
            weights[i] = 2*rnd.nextDouble()-1;
        }
    }

    /* Hilfsfunktion um eine Spalte mit lauter 1en einzufügen, damit sie mit w0 multipliziert werden kann.
     * z. B.    x[0] x[1]     x[0] x[1] x[2]
     *            0    0        1    0    0
     *       aus  0    1  wird  1    0    1
     *            1    0        1    1    0
     *            1    1        1    1    1
     */
    private int[][] createArrayWith1InFirstColumn(int[][] _x) {
        int[][] x = new int[_x.length][];

        for ( int i = 0; i < x.length; i++ ) {
            x[i] = new int[_x[i].length+1];
            x[i][0] = 1;

            // Kopieren des bisherigen Arrays
            for ( int j = 0; j < _x[i].length; j++ )
                x[i][j+1] = _x[i][j];
        }

        return x;
    }

    private void printWeights() {
        for ( int i = 0; i < N; i++ )
            System.out.printf("w%d       ", i);

        System.out.println();

        for ( int i = 0; i < N; i++ )
            System.out.printf("%f ", weights[i]);

        System.out.println();
    }

    // Write-Methoden
    private void writeHeaderLine() {
        StringBuilder builder = new StringBuilder("\n");

        for ( int i = 0; i < N; i++ ) {
            builder.append(i == 0 ? "1 " : "x" + i);

            builder.append(String.format("*    w%d", i));

            if ( i != N-1 )
                builder.append("     + ");
        }

        builder.append("     =  summe      -> output");

        System.out.println(builder.toString());
    }

    private void writeInputs(int[] x) {
        for ( int i = 1; i < N; i++ ) {
            System.out.printf("x%d = %d  ", i, x[i]);
        }
    }
}
