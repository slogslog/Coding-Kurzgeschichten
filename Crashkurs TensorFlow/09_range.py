# Unterdrückt die AVX2 Warnung
import os
os.environ['TF_CPP_MIN_LOG_LEVEL']='2'

import tensorflow as tf

a = tf.range(1,21)
print(a.numpy())

b = tf.range(10,0,-2)
print(b.numpy())

c = tf.range(5., 13., 0.5)
print(c.numpy())

d = tf.linspace(-2., 3., 20)
print(d)
