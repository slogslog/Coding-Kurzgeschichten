import numpy as np
import matplotlib.pyplot as plt

def poly(x):
    return x**3-x+2

# Die Kurven sollen auf x = [-2, +1.5] mit 100 Punkten
# gezeichnet werden.
xmin = -2
xmax = 1.5
x = np.linspace(xmin, xmax, 100) # Erzeugt 100 Wert von -2 bis +1.5

fig = plt.figure(figsize=(4,4))
# plt.title('Plots')

fig, axs = plt.subplots(2, 2) # 2 Spalten, 2 Zeilen
fig.suptitle('Mehrere Plots')
# axs[0].plot(x, y)
# axs[1].plot(x, -y)

axs[0,0].plot(x, poly(x), color='r')
axs[0,0].set_title('x^3-x+2')
axs[0,0].grid(True)

axs[1,0].plot(x, np.sin(4*x)*3, color='green')
axs[1,0].set_title('3 sin(4x)')
axs[1,0].grid(True)

axs[0,1].plot(x, np.heaviside(x, 1.0), color='y')
axs[0,1].set_title('Heaviside Funktion')
axs[0,1].grid(True)

axs[1,1].plot(x, x*np.cos(5*x), color='y')
axs[1,1].set_title('x cos(2x)')
axs[1,1].grid(True)

#plt.grid(True)
#plt.legend()
plt.show()