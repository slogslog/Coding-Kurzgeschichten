namespace AkzeptorLOL;

public enum Input
{
    L,
    O,
    OTHER
}

public class AcceptorLOL
{
    private enum State
    {
        Z1, Z2, Z3, Z4
    }

    private State currentState;
    private readonly HashSet<State> acceptedStates;

    private Dictionary<State, Dictionary<Input, State>> transition;

    public AcceptorLOL()
    {
        acceptedStates = new HashSet<State>{ State.Z4 };
        Reset();

        //                   Eingangszustand -> (Alle Inputs -> Ausgangszustand)
        transition = new Dictionary<State, Dictionary<Input, State>>(5)
        {
            { State.Z1, new Dictionary<Input, State>
                {
                    { Input.L, State.Z2 },
                    { Input.O, State.Z1 },
                    { Input.OTHER, State.Z1 },
                }
            },
            { State.Z2, new Dictionary<Input, State>
                {
                    { Input.L, State.Z2 },
                    { Input.O, State.Z3 },
                    { Input.OTHER, State.Z1 },
                }
            },
            { State.Z3, new Dictionary<Input, State>
                {
                    { Input.L, State.Z4 },
                    { Input.O, State.Z1 },
                    { Input.OTHER, State.Z1 },
                }
            },
            { State.Z4, new Dictionary<Input, State>
                {
                    { Input.L, State.Z4 },
                    { Input.O, State.Z4 },
                    { Input.OTHER, State.Z4 },
                }
            },        
        };
    }

    public bool IsInAcceptedState => acceptedStates.Contains(currentState);

    public void Reset()
    {
        currentState = State.Z1;

        Console.WriteLine($"Current state: {currentState}");
    }

    public void ProcessInput(object sender, Input input)
    {
        ApplyInput(input);
    }
    
    private void ApplyInput(Input input)
    {
        State newState = transition[currentState][input];
        Console.WriteLine($"Input {input}: {currentState} -> {newState}");
        currentState = newState;
    }
}