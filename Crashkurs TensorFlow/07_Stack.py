# Unterdrückt die AVX2 Warnung
import os
os.environ['TF_CPP_MIN_LOG_LEVEL']='2'

import tensorflow as tf

a2d = tf.constant([ [1,2,3], [4,5,6] ])
print(a2d)

b2d = tf.reshape(tf.range(7, 13), [2, -1])
print(b2d)

c3d = tf.stack([a2d, b2d])
print(c3d)
print(c3d.numpy())
