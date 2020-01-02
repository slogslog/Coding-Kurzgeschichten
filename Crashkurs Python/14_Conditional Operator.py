# Console.Write("Gib eine Zahl ein: ");
# double number = double.Parse(Console.ReadLine());
#
# string output = number > 0 // Bedingter Operator ?:
#     ? "Die Zahl ist positiv."
#     : "Die Zahl ist 0 oder negativ";
#
# Console.WriteLine(output);

number = float(input("Gib eine Zahl ein: "))

output = "Die Zahl ist positiv." if number > 0 else \
    "Die Zahl ist negativ" if number < 0 else \
    "Die Zahl ist 0"

print(output)