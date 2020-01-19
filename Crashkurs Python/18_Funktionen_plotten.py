import matplotlib.pyplot as plt
import math

def poly(x):    # x^3 - x + 2
    return x**3-x+2

def some_sinus(x):   # 3.sin(4x)
    return 3 * math.sin(4*x)

# Die Kurven sollen auf x = [-2, +1.5] mit einem 0.1 Intervall
# gezeichnet werden.
resolution = 0.1
xmin = -2
xmax = 1.5

plt.figure(figsize=(4,4))  # 400x400 Pixel
plt.title('Funktion')

# x -> 0..35    xrange = [-2 -1.9 ... +1.4 +1.5]
x = [ xmin+x*resolution for x in range(int((xmax-xmin)/resolution+1))]
y = [poly(x) for x in x ]
y2 = [some_sinus(x) for x in x ]

plt.plot(x, y, label='x^3-x+2', color='red')
plt.plot(x, y2, label='sin(4x)-3', color='g')

plt.grid(True)
plt.legend()
plt.show()