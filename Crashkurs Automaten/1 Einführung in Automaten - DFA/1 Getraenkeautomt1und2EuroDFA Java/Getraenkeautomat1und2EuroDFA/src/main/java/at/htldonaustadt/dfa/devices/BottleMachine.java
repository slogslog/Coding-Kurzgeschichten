package at.htldonaustadt.dfa.devices;

import at.htldonaustadt.dfa.finitestatemachine.*;

import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;

public class BottleMachine {

    private Set<Event> subscribers = new HashSet<>();

    public void subscribe(Event subscriber) {
        if (subscriber != null)
            subscribers.add(subscriber);
    }

    public void unsubscribe(Event subscriber) {
        subscribers.remove(subscriber);
    }

    public void Run() {
        try (Scanner scanner = new Scanner(System.in)) {

            while (true) {
                System.out.print("Welche Münze wird eingeworfen? 1 oder 2? ");

                Input input = switch (scanner.next()) {
                    case "1" -> Input.EURO1;
                    case "2" -> Input.EURO2;
                    default -> throw new IllegalStateException("Invalid input!");
                };

                onInput(input);
            }
        }
    }

    public void onInput(Input input) {
        for (Event subscriber : subscribers) {
            subscriber.processInput(input);
        }
    }
}
