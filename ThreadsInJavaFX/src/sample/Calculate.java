package sample;

import javafx.application.Platform;
import javafx.scene.control.ListView;

public class Calculate implements Runnable {

    private ListView<String> lv;
    private boolean squares;

    public Calculate(ListView<String> lv, boolean squares ) {
        this.lv = lv;
        this.squares = squares;
    }

    @Override
    public void run() {

        for ( double x = 0; x <= 20; x++ ) {
            double number = squares ? x*x : Math.sqrt(x);
            //lv.getItems().add(String.valueOf(number));
            Platform.runLater( ()->lv.getItems().add(String.valueOf(number)) );

            try {
                Thread.sleep(200);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }

    }
}
