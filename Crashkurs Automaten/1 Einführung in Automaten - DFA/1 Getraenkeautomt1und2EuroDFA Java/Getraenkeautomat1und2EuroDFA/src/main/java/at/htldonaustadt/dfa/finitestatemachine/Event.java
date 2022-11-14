package at.htldonaustadt.dfa.finitestatemachine;

public interface Event {
    void processInput(Input input);
}
