


using AkzeptorLOL;

while (true)    
{
    Console.Write("Gib einen String ein: ");

    string text = Console.ReadLine();

    StringValidator validator = new StringValidator(text);
    Console.WriteLine($"{text} -> {validator.IsAccepted}");
}
