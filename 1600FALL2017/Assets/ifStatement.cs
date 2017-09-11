using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatement : MonoBehaviour {

	public int num1;
	public int num2;
	public int value;

	public bool canPlay = true;

	public string input;
	private string password = "password";

	void Start () {
		if(num1 + num2 == value)
		{
			print(value);
		}

		if (canPlay)
		{
			print("Play");
		}

		if (input == password)
		{
			print("You know the password");
		}
	}
}