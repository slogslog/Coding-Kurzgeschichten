# if funktioniert (fast) wie in allen anderen Sprachen
# - Einrückungen ersetzen { } Gilt für Python generell!
# - Es gibt ein elif statt einem else if

weight = 50  # kg
height = 190 # cm

bmi = weight / (height/100)**2

# bmi < 18.5 : Untergewicht
# bmi > 25   : Übergewicht
# sonst      : Normalgewicht

if bmi < 18.5:
    print("Untergewicht")
    print("Mehr essen!")
elif bmi > 25:
    print("Übergewicht")
else:
    print("Normalgewicht")