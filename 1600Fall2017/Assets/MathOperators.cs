using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {

	public float num1;
	public float num2;

	public float addResult;
	public float subResult;
	public float multResult;
	public float divResult;
	public float remainderResult;

	void Update () {
		addResult = num1 + num2; //adds both vars together
		subResult = num1 - num2; //subtracts the second var from the first
		multResult = num1 * num2; //multiplies both vars together
		if(num1 != 0 && num2 != 0) {
			divResult = num1 / num2; //divides the first var by the second
		} else {
			print("Can't divide by zero!");
		}
		remainderResult = num1 % num2; //denotes the remainder of the divresult
	}
}