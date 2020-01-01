# static void Main(string[] args)
# {
#     int counter = 10;
#
#     while (counter != 0)
#     {
#         Console.WriteLine(counter);
#         counter--;
#     }
#
#     Console.WriteLine("Nach der Schleife");
# }

# Besonderheit: while haben in Python ein else!

counter = 10

while counter != 0:
    print(counter, end=' ')
    counter-=1

    if counter == 3:
        break;
else:
    print("Die Schleife wurde verlassen")

print("Nach der Schleife")