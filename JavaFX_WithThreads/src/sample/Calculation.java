package sample;

import javafx.application.Platform;
import javafx.scene.control.ListView;

public class Calculation implements Runnable {

    private Kind kind;
    private ListView<String> listView;

    public Calculation(Kind kind, ListView<String> listView) {
        this.kind = kind;
        this.listView = listView;
    }

    @Override
    public void run() {

        for ( double number = 0; number <= 20; number++ ) {
            double x = kind == Kind.SQUARES
                       ? number * number
                       : Math.sqrt(number);

            Platform.runLater(
                    () -> listView.getItems().add(String.valueOf(x))
            );

            // listView.getItems().add(String.valueOf(x));

            try {
                Thread.sleep(200);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }

    }
}
