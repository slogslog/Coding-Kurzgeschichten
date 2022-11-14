using Getraenkeautomat1und2EuroDFA;

/*  Dieses Programm ist die Umsetzung des Getränkeautomaten in
    "1 Einführung in Automaten - DFA"
 */
DFA automaton = new DFA();

BottleMachine device = new BottleMachine();
device.OnInput += automaton.ProcessInput;

device.Run();