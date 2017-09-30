using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour {
//If statements execute a statement if a bool expresison is true

	public Text input;
	public bool canPlayGame = false;
	public string password = "password";
	void Update () {
		if(input.text == password) {
			print("You know the password.");
			canPlayGame = true;
		} else {
			print("The password is incorrect.");
		}
		if(canPlayGame){
			print("Playing Game");
		}	else {
			print("Can't play yet, enter a correct password ya dingus");
		}
	}
}
// Use an if statement to compare the truth of one thing to another
// If there's truth to a statement, the code will run, otherwise nothing will happen