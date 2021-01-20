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
    ListView<String> rootNumbers;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {

    }

    @FXML
    public void onStart(Event event) {

        Calculation calcSquares = new Calculation(Kind.SQUARES, squareNumbers);
        Calculation calcRoots = new Calculation(Kind.ROOTS, rootNumbers);

//        calcSquares.run();
//        calcRoots.run();
        Thread tsquares = new Thread(calcSquares);
        tsquares.start();

        Thread troots = new Thread(calcRoots);
        troots.start();
    }

}
