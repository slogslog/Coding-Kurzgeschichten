package at.htldonaustadt.dfa;

import at.htldonaustadt.dfa.devices.BottleMachine;
import at.htldonaustadt.dfa.finitestatemachine.DFA;

public class Main {
    /*  Dieses Programm ist die Umsetzung des Getränkeautomaten in
    "1 Einführung in Automaten - DFA"
    */
    public static void main(String[] args) {
        DFA dfa = new DFA();

        BottleMachine device = new BottleMachine();
        device.subscribe(dfa);

        device.Run();
    }
}