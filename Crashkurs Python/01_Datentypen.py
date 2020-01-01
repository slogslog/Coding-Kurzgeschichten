h = 100
kg = 103.54 # kg
doesItRain = False
x = 3+4j
y = 5-2j

print(h)
print("Höhe:", h)

town1 = "Vienna"
town2 = 'Vienna'

print(type(h))
print(type(kg))
print(type(town1))

# wie in C++ und Java
print("Höhe: %d Gewicht: %.1f\nStadt: %s" % ( h, kg, town2 ) )

# indexbasierte Ausgabe
print("Höhe: {0} Gewicht: {1:.1f}\nStadt: {2}\n{0}".format(h, kg, town2))