# Unterdrückt die AVX2 Warnung
import os
os.environ['TF_CPP_MIN_LOG_LEVEL']='2'

import tensorflow as tf

# 2d-Array
# [ [1, 1, 1],
#   [1, 1, 1],
#   [1, 1, 1],
#   [1, 1, 1] ]

a = tf.ones([4, 3])
print(a)

b = tf.zeros([2, 5])
print(b)

c = tf.fill([3, 10], 42)
print(c.numpy())

d = tf.eye(3,6)
print(d.numpy())

e = tf.random.uniform([2,5], 0, 4)
print(e)