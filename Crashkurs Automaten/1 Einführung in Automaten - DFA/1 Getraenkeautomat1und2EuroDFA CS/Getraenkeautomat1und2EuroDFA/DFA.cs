namespace Getraenkeautomat1und2EuroDFA;

public enum Input
{
    _1EURO,
    _2EURO
}

public class DFA
{
    private enum State
    {
        S, Z1, Z2, Z3, ZOVERFLOW
    }

    private State currentState;
    private HashSet<State> endStates;

    private Dictionary<State, Dictionary<Input, State>> transition;

    public DFA()
    {
        endStates = new HashSet<State>{ State.Z3 };
        Reset();

        //                   Eingangszustand -> (Alle Inputs -> Ausgangszustand)
        transition = new Dictionary<State, Dictionary<Input, State>>(5)
        {
            { State.S, new Dictionary<Input, State>
                {
                    { Input._1EURO, State.Z1 },
                    { Input._2EURO, State.Z2 }
                }
            },
            { State.Z1, new Dictionary<Input, State>
                {
                    { Input._1EURO, State.Z2 },
                    { Input._2EURO, State.Z3 }
                }
            },
            { State.Z2, new Dictionary<Input, State>
                {
                    { Input._1EURO, State.Z3 },
                    { Input._2EURO, State.ZOVERFLOW }
                }
            },
            { State.ZOVERFLOW, new Dictionary<Input, State>
                {
                    { Input._1EURO, State.ZOVERFLOW },
                    { Input._2EURO, State.ZOVERFLOW }
                }
            },        
        };
    }

    public void Reset()
    {
        currentState = State.S;

        Console.WriteLine($"Current state: {currentState}");
    }

    public void ProcessInput(object sender, Input input)
    {
        ApplyInput(input);
    }
    
    private void ApplyInput(Input input)
    {
        State newState = transition[currentState][input];
        Console.WriteLine($"Change from {currentState} -> {newState}");
        currentState = newState;
        
        if (endStates.Contains(currentState))
        {
            Console.WriteLine("Endzustand erreicht!");
        }
    }
}