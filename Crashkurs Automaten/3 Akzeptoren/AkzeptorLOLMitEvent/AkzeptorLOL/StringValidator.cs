namespace AkzeptorLOL;

public class StringValidator
{
    private String sequence;
    
    public StringValidator(string sequence) => this.sequence = sequence;

    public EventHandler<Input> NextInput;

    public bool IsAccepted
    {
        get
        {
            AcceptorLOL automaton = new AcceptorLOL();
            NextInput += automaton.ProcessInput;

            foreach ( char c in sequence)
            {
                Input input = c switch
                {
                    'L' => Input.L,
                    'O' => Input.O,
                    _ => Input.OTHER
                };
                
                NextInput?.Invoke(this, input);
            }

            return automaton.IsInAcceptedState;
        }
    }
}
