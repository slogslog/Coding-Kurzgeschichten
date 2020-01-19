# Unterdrückt die AVX2 Warnung
import os
os.environ['TF_CPP_MIN_LOG_LEVEL']='2'

import tensorflow as tf

number1 = tf.constant(13.)
sum = tf.add(number1, 37.)

print(sum)
sum_py = sum.numpy() # toString/ToString in Java/C#

print(sum_py)

s1 = 'hello'
res = tf.strings.join([s1, 'world'])

print(res)
print(res.numpy())
