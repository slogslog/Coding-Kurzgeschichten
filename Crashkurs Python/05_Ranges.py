# Ein Range stellt einen Wertebereich dar
# range ist ein eigener Datentyp in Python
# (Seit C# 8 auch in C# verfügbar)

r = range(6) # startet bei 0 und endet bei 5
print(r)
print(type(r))

r1 = range(2,6)

r2 = range(2,10,2)

r3 = range(10,-4,-3)

for i in r3:
    print(i)
