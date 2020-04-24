package sample;

import javafx.event.Event;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.GridPane;

import java.net.URL;
import java.util.ResourceBundle;

public class Controller implements Initializable {

    @FXML Button incrementButton;
    @FXML Label counter;
    @FXML GridPane gridPane;

    @FXML void onClick(Event event) {
        int value = Integer.valueOf(counter.getText());
        counter.setText(String.valueOf(value+1));


//        Alert alert = new Alert(Alert.AlertType.INFORMATION, "Nice to see you!");
//        alert.show();
    }

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {

        Label a = new Label();
        a.setText("Hello!!!!");
        gridPane.getChildren().add(a);
        GridPane.setColumnIndex(a, 2);
        GridPane.setRowIndex(a, 2);

    }
}
