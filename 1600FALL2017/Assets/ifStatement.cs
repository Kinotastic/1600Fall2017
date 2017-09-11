using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour {

	public Text input;
	public string password = "password";

	void Update () {
		if(input.text == password) {
			print("You know the password.");
		}

	}


}
// Use an if statement to compare the truth of one thing to another
// If there's truth to a statement, the code will run, otherwise nothing will happen