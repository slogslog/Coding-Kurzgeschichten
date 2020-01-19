# Unterdrückt die AVX2 Warnung
import os
os.environ['TF_CPP_MIN_LOG_LEVEL']='2'

import tensorflow as tf

# number = float(input("Gib eine Zahl ein: "))
#
# number_tf = tf.constant(number)
#
# result = tf.pow(number_tf, 3.) # number**3
# print("{0}^3 = {1}".format(number, result))
#
# print(result)
# print(result.numpy())  # toString/ToString in Java/C#


# 1d Arrays: new int[3] in C# und Java
a1d = tf.constant([4, 3, 5], tf.dtypes.float32)
print(a1d)
print(a1d.numpy())

# 2d Arrays: new int[3, 2] in C# bzw. new int[3][2] in Java
# 1. Index: Zeilen
# 2. Index: Spalten
a2d = tf.constant([[4, 2],
                   [3, 1],
                   [5, 0]])
print(a2d)
print(a2d.numpy())

# 3d Arrays: new int[4, 2, 3] in C# bzw. new int[4][2][3] in Java
# 1. Index: Schicht (Layer)
# 2. Index: Zeilen
# 3. Index: Spalten
a3d = tf.constant([
    [ [1,1,1],
      [2,2,2] ],
    [ [3,3,3],
      [4,4,4] ],
    [ [5,5,5],
      [6,6,6] ],
    [ [7,7,7],
      [8,8,8]]])
print(a3d)
print(a3d.numpy())
