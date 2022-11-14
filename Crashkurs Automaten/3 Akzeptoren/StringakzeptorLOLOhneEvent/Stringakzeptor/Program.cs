using Stringakzeptor;


Stringacceptor validator = new Stringacceptor();

while (true)    
{
    Console.Write("Gib einen String ein: ");

    string text = Console.ReadLine();

    Console.WriteLine($"{text} -> {validator.IsAccepted(text)}");
}