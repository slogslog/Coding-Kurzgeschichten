# Alle Quadratzahlen von 1..12 in eine Liste kopieren
domain = range(1,13)

# langsam
squares = []

for i in domain:
    squares.append(i*i)

print(squares)

# list comprehension
squares2 = [i*i for i in domain]
print(squares2)

# nur für die ungeraden Zahlen
squares3 = [i*i for i in domain if i % 2 == 1]
print(squares3)

# Bedingung vorne ['odd','even',...]
kind = [ 'even' if i % 2 == 0 else 'odd' for i in domain ]
print(kind)
