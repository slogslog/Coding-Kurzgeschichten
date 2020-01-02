# Instanzvariablen werden nur dynamisch angelegt!
# Und NICHT beim Erstellen einer Instanz/des Objekts

class Person:
    def __init__(self, name):       # Konstruktor
        self.name = name            # legt name als Instanzvariable an

    def setNickname(self, nickname):
        self.nickname = nickname    # legt nickname als Instanzvariable an

    def __str__(self):              # toString()/ToString() in Java/C#
        return 'Name: {0} "{1}"'.format(self.name, self.nickname)

p1 = Person("Marko Arnautovic")
p1.setNickname("Nautl")
print(p1)
