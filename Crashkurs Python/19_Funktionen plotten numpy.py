import numpy as np
import matplotlib.pyplot as plt

def poly(x):    # x^3 - x + 2
    return x**3-x+2

# Die Kurven sollen auf x = [-2, +1.5] mit 100 Punkten
# gezeichnet werden.
xmin = -2
xmax = 1.5
# x = [-2 -1.9 ... +1.4 +1.5]
x = np.linspace(xmin, xmax, 100) # Erzeugt 100 Wert von -2 bis +1.5

plt.figure(figsize=(4,4)) # 400x400 Pixel
plt.title('Plots')

plt.plot(x, poly(x), label='x^3-x+2', color='r')
plt.plot(x, np.sin(4*x)*3, label='3 sin(4x)', color='g')

plt.grid(True)
plt.legend()
plt.show()