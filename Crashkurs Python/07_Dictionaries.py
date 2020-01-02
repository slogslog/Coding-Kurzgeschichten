# Frühling, Sommer, Herbst, Winter
# spring, summer, autumn, winter

seasons = { 'Frühling': 'spring',
            'Sommer': 'summer',
            'Herbst': 'autumn',
            'Winter': 'winter'
} # wie in JSON

print(seasons)

# german = input("Gib eine Jahreszeit auf Deutsch ein: ")

# Ausgabe des englischen Worts
# english = seasons[german]

#english = seasons.get(german, 'Ungültig!')

#print(english)

for g in seasons.keys():
    print(g)

for e in seasons.values():
    print(e)

for g, e in seasons.items():
    print("%s ist das englische Wort für %s" % (e, g) )
