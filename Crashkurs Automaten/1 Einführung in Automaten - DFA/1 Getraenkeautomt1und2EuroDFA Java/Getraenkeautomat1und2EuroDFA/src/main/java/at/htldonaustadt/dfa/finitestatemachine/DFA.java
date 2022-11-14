package at.htldonaustadt.dfa.finitestatemachine;

import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;

public class DFA implements Event{
    private State currentState;
    private Set<State> endStates;

    private Map<State, Map<Input, State>> transition;

    public DFA()
    {
        endStates = Set.of(State.Z3);
        reset();

        // Eingangszustand -> (Alle Inputs -> Ausgangszustand)
        Map<Input, State> mapS  = Map.of(Input.EURO1, State.Z1, Input.EURO2, State.Z2);
        Map<Input, State> mapZ1 = Map.of(Input.EURO1, State.Z2, Input.EURO2, State.Z3);
        Map<Input, State> mapZ2 = Map.of(Input.EURO1, State.Z3, Input.EURO2, State.ZOVERFLOW);
        Map<Input, State> mapZoverflow = Map.of(Input.EURO1, State.ZOVERFLOW, Input.EURO2, State.ZOVERFLOW);

        transition = Map.of(
                State.S, mapS,
                State.Z1, mapZ1,
                State.Z2, mapZ2,
                State.ZOVERFLOW, mapZoverflow
        );
    }

    public void reset()
    {
        currentState = State.S;

        System.out.println("Current state: "+currentState);
    }

    @Override
    public void processInput(Input input) {
        applyInput(input);
    }

    private void applyInput(Input input)
    {
        State newState = transition.get(currentState).get(input);
        System.out.println("Change from "+currentState+" -> "+newState);
        currentState = newState;

        if (endStates.contains(currentState))
        {
            System.out.println("Endzustand erreicht!");
        }
    }
}
