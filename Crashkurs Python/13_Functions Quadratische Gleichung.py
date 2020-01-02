# Allgemeine Lösung für eine quadratische Gleichung
# Mit Fallunterscheidung! Die in Python gar nicht notwendig ist...

from math import sqrt

def solve(a,b,c):
    d = b**2 - 4*a*c
    if d < 0:
        return "Keine reelle Lösung"
    elif d == 0:
        return -b/(2*a)

    root = sqrt(d)
    return (-b+root)/(2*a), (-b-root)/(2*a)

a = float(input("a="))
b = float(input("b="))
c = float(input("c="))

res = solve(a,b,c)

if isinstance(res, str):
    print(res)
elif isinstance(res,float):
    print("Nur eine Lösung", res)
else:
    print('x1=',res[0], 'x2=',res[1])