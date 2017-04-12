package com.java2s;

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.StackPane;
import javafx.scene.layout.VBox;
import javafx.scene.shape.Line;
import javafx.stage.Stage;

//w w  w.j  ava 2s  .  c  o m
public class Main extends Application {

	@Override
	public void start(Stage stage) {
		VBox box = new VBox();
		final Scene scene = new Scene(box, 300, 250);
		scene.setFill(null);

		Line line = new Line();
		line.setStartX(0.0f);
		line.setStartY(0.0f);
		line.setEndX(100.0f);
		line.setEndY(100.0f);
		Line line2 = new Line(200, 10, 10, 110);

		box.getChildren().add(line);
		box.getChildren().add(line2);

		stage.setScene(scene);
		stage.show();
	}

//	@Override
//	public void start(Stage primaryStage) {
//		Line line = new Line(200, 10, 10, 110);
//		Button btn = new Button();
//		btn.setText("Say 'Hello World'");
//		btn.setOnAction(new EventHandler<ActionEvent>() {
//
//			@Override
//			public void handle(ActionEvent event) {
//				System.out.println("Hello World!");
//			}
//		});
//
//		StackPane root = new StackPane();
//
//		root.getChildren().add(line);
//		root.getChildren().add(btn);
//
//		Scene scene = new Scene(root, 300, 250);
//
//		primaryStage.setTitle("Hello World!");
//		primaryStage.setScene(scene);
//		primaryStage.show();
//	}

	public static void main(String[] args) {
		launch(args);
	}
}
