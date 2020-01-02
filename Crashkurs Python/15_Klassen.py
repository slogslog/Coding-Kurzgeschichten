# Übungsaufgabe: Auto mit Booster in Python

class Booster:
    powerOn = False             # erzeugt und initialisiert eine Instanzvariable

    def __init__(self, stufe):  # Konstruktor
        self.stufe = stufe      # self ist 'this' in Java/C# -> erzeugt eine Instanzvariable

    def getPower(self):         # Methoden ohne self sind static
        return self.powerOn

    def setPower(self, powerOn):
        self.powerOn = powerOn

    def getStufe(self):
        return self.stufe

    def setStufe(self, stufe):
        self.stufe = stufe

    def __str__(self): # toString() in Java/ToString() in C#
        return "Power OFF" if not self.powerOn else \
               "Power ON - Stufe {0}".format(self.stufe)

class Auto:
    def __init__(self, marke, vmax):
        self.marke = marke
        self.vmax = vmax
        self.booster = None     # ist 'null' in Java/C#

    def getBooster(self):
        return self.booster

    def setBooster(self, booster):
        self.booster = booster

    def getVMax(self):
        v = self.vmax

        if self.booster is not None:    # None = null
            if self.booster.getPower():
                acc = { 1: 15, 2: 30 }  # in percent
                percent = acc.get(self.booster.getStufe(), 0)
                v *= 1+percent/100

        return v

    def getFahrzeit(self, wegstrecke):
        return wegstrecke/self.getVMax()

    def __str__(self):
        text = "Kein Booster" if self.booster is None else self.booster
        return "{0}: vmax = {1} Booster: {2}".\
            format(self.marke, self.getVMax(), text)

# 1. Erstelle einen Booster mit Stufe 1
booster = Booster(1)    # Erstellen einer Instanz/eines Objekts

# 2. Erstelle das Auto Ferrari SP3JC mit Höchstgeschwindigkeit 320 km/h
ferrari = Auto('Ferrari SP3JC', 320)

# 3. Erstelle das Auto BMW Z1 mit Höchstgeschwindigkeit 260 km/h
bmw = Auto('BMW Z1', 260)

# 4. Führe die 400 km-Fahrt mit dem Ferrari SP3JC aus und gibt die Fahrzeit aus
#    Gib den Ferrari auf der Console aus.
tferrari = ferrari.getFahrzeit(400)
print('Der Ferrari benötigt {0:.3f} Stunden.'.format(tferrari))
print(ferrari)

tbmw = []

# Führe die Fahrt mit dem BMW Z1 aus.
# Gib nach jedem Streckenabschnitt die Statuswerte des Fahrzeugs aus.
# 1. Strecke: 20 km - ohne Booster
tbmw.append(bmw.getFahrzeit(20))
print(bmw)

# 2. Strecke: 140 km - mit eingeschaltenen Booster auf Stufe 1
bmw.setBooster(booster)
booster.setPower(True)
booster.setStufe(1)
tbmw.append(bmw.getFahrzeit(140))
print(bmw)

# 3. Strecke: 180 km - mit eingeschaltenen Booster auf Stufe 2
booster.setStufe(2)
tbmw.append(bmw.getFahrzeit(180))
print(bmw)

# 4. Strecke: 60 km - mit abgeschaltetem Booster
booster.setPower(False)
tbmw.append(bmw.getFahrzeit(60))
print(bmw)

for t in tbmw:
    print("Fahrzeit {0:.3f}".format(t))

print('Der BMW benötigt {0:.3f} Stunden.'.format(sum(tbmw)))
