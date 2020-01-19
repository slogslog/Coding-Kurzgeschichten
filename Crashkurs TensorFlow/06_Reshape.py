# Unterdrückt die AVX2 Warnung
import os
os.environ['TF_CPP_MIN_LOG_LEVEL']='2'

import tensorflow as tf

# Liste
r = tf.range(1,28)
print(r)
print(r.numpy())

# 2d-Array (Tensor mit Rang 2)
r2 = tf.reshape(r, [3, -1])
print(r2)
print(r2.numpy())

# 3d-Array (Tensor mit Rang 3)
r3 = tf.reshape(r, [3, 3, -1])
print(r3)
print(r3.numpy())

rpart = tf.slice(r2, [1, 2], [2, 3] )
print(rpart)
