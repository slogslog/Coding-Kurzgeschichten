# Unterdrückt die AVX2 Warnung
import os
os.environ['TF_CPP_MIN_LOG_LEVEL']='2'

import tensorflow as tf

from math import sqrt

def solve(a,b,c):
    # d = b**2 - 4*a*c
    d = tf.subtract(tf.pow(b, 2.), tf.multiply(4., tf.multiply(a, c)))

    a2 = tf.multiply(2., a)

    return tf.cond(tf.less(d, 0.),
                   lambda: tf.constant("Keine reelle Lösung"),
                   lambda: tf.cond( tf.equal(d, 0.),
                            lambda: tf.divide(tf.negative(b), a2), # nur eine Lösung
                            lambda: tf.tuple(
                                [   tf.divide(
                                        tf.add(tf.negative(b), tf.sqrt(d)),
                                        a2 ),
                                    tf.divide(
                                        tf.subtract(tf.negative(b), tf.sqrt(d)),
                                        a2)
                                ]
                            )
                   ))
    #if d < 0:
    #    return "Keine reelle Lösung"
    #elif d == 0:
    #    return -b/(2*a)

    #root = sqrt(d)
    #return (-b+root)/(2*a), (-b-root)/(2*a)

a = float(input("a="))
b = float(input("b="))
c = float(input("c="))

res = solve(a,b,c)

if isinstance(res, list):
    print('x1=', res[0].numpy(), 'x2=', res[1].numpy())
elif res.dtype == tf.string:
    print(res.numpy())
else:
    print('x1=x2=', res.numpy())
