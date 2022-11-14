namespace Getraenkeautomat1und2EuroDFA;


// repräsentiert den Mineralwasserflaschengeräteautomat
public class BottleMachine
{
    public event EventHandler<Input> OnInput;

    public void Run()
    {
        while (true)    
        {
            Console.Write("Welche Münze wird eingeworfen? 1 oder 2?");

            string text = Console.ReadLine();

            Input input = text switch
            {
                "1" => Input._1EURO,
                "2" => Input._2EURO,
            };
            
            OnInput?.Invoke(this, input);
        }
    }
}
