# Unterdrückt die AVX2 Warnung
import os
os.environ['TF_CPP_MIN_LOG_LEVEL']='2'

import tensorflow as tf

# Console.Write("Wie ist Dein Name? ");
# string name = Console.ReadLine();
#
# Console.Write("Gewicht in kg: ");
# double weight = double.Parse(Console.ReadLine());
#
# Console.Write("Größe in cm: ");
# int height = int.Parse(Console.ReadLine());
#
# double bmi = weight / Math.Pow(height/100.0, 2);
#
# Console.WriteLine($"{name} hat einen BMI von {Math.Round(bmi,1)}");

name = input("Wie ist Dein Name? ")
weight = float(input('Gewicht in kg: '))
height = int(input('Größe in cm: '))

heighttf = tf.constant(height, tf.dtypes.float32)
bmitf = tf.divide( tf.constant(weight), tf.pow( tf.divide(heighttf, 100.), 2.))
bmi = bmitf.numpy() # toString in Java    tensor -> python datatype
print("bmi=", bmi)
