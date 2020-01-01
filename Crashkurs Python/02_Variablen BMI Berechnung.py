# Console.Write("Wie ist Dein Name? ");
# string name = Console.ReadLine();
#
# Console.Write("Gewicht in kg: ");
# double kg = double.Parse(Console.ReadLine());
#
# Console.Write("Größe in cm: ");
# int cm = int.Parse(Console.ReadLine());
#
# double bmi = kg / Math.Pow(cm/100.0, 2);
#
# Console.WriteLine($"{name} hat einen BMI von {Math.Round(bmi,1)}");

name = input("Wie ist Dein Name? ")
kg = float(input("Gewicht in kg: "))
cm = int(input("Größe in cm: "))

bmi = kg / (cm/100)**2

print(name, "hat einen BMI von", round(bmi,1) ) # Console.WriteLine

print("Die BMI-Berechnung ergab:", end='') # Console.Write
print(bmi)
