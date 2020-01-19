# Unterdrückt die AVX2 Warnung
import os
os.environ['TF_CPP_MIN_LOG_LEVEL']='2'

import tensorflow as tf

def perceptron_with_heaviside(x,w):
    sum = tf.reduce_sum(tf.multiply(tf.constant(x, tf.dtypes.float32),
                                    tf.constant(w, tf.dtypes.float32)))

    # if
    return tf.cond(tf.greater(sum, 0.),
                   lambda: tf.constant(1.),
                   lambda: tf.constant(0.)).numpy()

x = [1, 3, 4]
w = [0.3, -0.2, 0.6]

fires = perceptron_with_heaviside(x,w)
print(fires)

fires = perceptron_with_heaviside([1, 3, -4],w)
print(fires)