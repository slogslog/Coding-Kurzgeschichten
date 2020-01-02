a = [1, 2, 4, 2, 8, 1, 1]

# Sets speichern nichts doppelt
s = set()

for i in a:
    s.add(i)

print(s)

s2 = set(a)
print(s2)

# Lottozahlen 6 aus 45:

import random as rnd

lotto = set()

#randrange ist wie in C# und Java
while len(lotto) != 6:
    lotto.add(rnd.randint(1,45))

print(lotto)
