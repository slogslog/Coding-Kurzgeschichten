package sample;

import javafx.event.Event;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.ListView;

import java.net.URL;
import java.util.ResourceBundle;

public class Controller implements Initializable {

    @FXML
    ListView<String> squareNumbers;

    @FXML
    ListView<String>  rootNumbers;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {

    }

    public void onStart(Event event) {
//        Alert a = new Alert(Alert.AlertType.INFORMATION);
//        a.show();

        Calculate calcSquares = new Calculate(squareNumbers, true);
        Calculate calcRoots = new Calculate(rootNumbers, false);

//        calcSquares.run();
//        calcRoots.run();
        Thread t1 = new Thread(calcSquares);
        Thread t2 = new Thread(calcRoots);

        t1.start();
        t2.start();
    }
}
