using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour {
/*Else clauses apply to the immediate predecing "if statement" in the block
	For example:
	if (true)
		if (false)
			Console.WriteLine();
		else
			Console.WriteLine();

You can also nest an if statement within an else clause
	For example:
	if (2 + 2 == 5)
		Console.WriteLine ("Does Not Compute");
	else
		if (2 + 2 == 4)
			Console.WriteLine ("Computes");
*/
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