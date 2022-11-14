namespace Stringakzeptor;



public class Stringacceptor
{
    private enum Input
    {
        L,
        O,
        OTHER
    }
    
    private enum State
    {
        Z1, Z2, Z3, Z4
    }

    private State currentState;
    private readonly HashSet<State> acceptedStates;

    private Dictionary<State, Dictionary<Input, State>> transition;

    public Stringacceptor()
    {
        acceptedStates = new HashSet<State>{ State.Z4 };

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

    public bool IsAccepted(string sequence)
    {
        currentState = State.Z1;
        Console.WriteLine($"Current state: {currentState}");
        
        foreach (char c in sequence)
        {
            Input input = c switch
            {
                'L' => Input.L,
                'O' => Input.O,
                _ => Input.OTHER
            };
                
            ApplyInput(input);
        }

        return acceptedStates.Contains(currentState);
    }
    
    private void ApplyInput(Input input)
    {
        State newState = transition[currentState][input];
        Console.WriteLine($"Input {input}: {currentState} -> {newState}");
        currentState = newState;
    }
}