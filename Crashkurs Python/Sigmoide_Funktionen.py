import numpy as np
import matplotlib.pyplot as plt

xlim = 10
x = np.linspace(-xlim, xlim, 500)

plt.figure(figsize=(3,3)) # 400x400 Pixel

plt.title('Heaviside Funktion', fontsize=20)
plt.plot(x, np.heaviside(x, 1.0), linewidth=10, color='red')
plt.xlim([-10, 10])
plt.grid(True)
plt.show()

input("Drück eine Taste...")

plt.title('Sigmoid (Logistische Funktion)', fontsize=20)
plt.plot(x, 1./(1.+np.exp(-x)), linewidth=10, color='green')
plt.text(-9, 0.85, r'$\sigma(x)=\frac{1}{1+e^{-x}}$', fontsize=30)
plt.xlim([-10, 10])
plt.grid(True)
plt.show()

input("Drück eine Taste...")

plt.title('Aktivierungsfunktionen')
plt.plot(x, np.heaviside(x, 10.0), label='Heaviside', linewidth=10, color='red')
plt.plot(x, 1./(1.+np.exp(-x)), label='Logistische Funktion', linewidth=10, color='green')
plt.xlim([-10, 10])
plt.grid(True)
plt.legend()
plt.show()

input("Drück eine Taste...")

fig, axs = plt.subplots(2, 1)

axs[0].plot(x, 1./(1.+np.exp(-x)), color='green')
axs[0].set_title('Logistische Funktion')
axs[0].text(-10, 0.85, r'$\sigma(x)=\frac{1}{1+e^{-x}}$', fontsize=25, color='green')
axs[0].grid(True)

axs[1].plot(x, 1./(1.+np.exp(-x))*(1-1./(1.+np.exp(-x))), color='red')
axs[1].set_title('Änderung (1. Ableitung)')
axs[1].text(-10, 0.15, r'$\sigma\'(x)=\sigma(x).(1-\sigma(x))$', fontsize=15, color='red')
axs[1].grid(True)

plt.show()

input("Drück eine Taste...")

plt.title('Tangens Hyperbolicus', fontsize=20)
plt.plot(x, np.tanh(x), linewidth=10, color='orange')
plt.text(-9, 0.75, r'$\sigma(x)=tanh(x)'
                   r'$', fontsize=25)
plt.xlim([-10, 10])
plt.grid(True)
plt.legend()
plt.show()

input("Drück eine Taste...")

plt.title('ReLU-Funktion', fontsize=20)
plt.plot(x, np.maximum(0,x), linewidth=10, color='blue')
plt.xlim([-10, 10])
plt.grid(True)

plt.legend()
plt.show()

input("Drück eine Taste...")

