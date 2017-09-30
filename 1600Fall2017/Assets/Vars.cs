using UnityEngine;
public class Vars : MonoBehaviour {
	public float health = 100; //this is a variable.
	void OnTriggerEnter()
	{
		health += 20; //this statement adds a number to the original variable.
	}
}

/* Some more examples of vars:
public class Variables : MonoBehaviour
{
	int myInt = 5 //the 5 is a variable in this statement
	void Start (){
		myInt = MultiplyByTwo(myInt);
		Debug.Log (myInt);
			}
	int MultiplyByTwo(int number){
		int ret;
		ret = number * 2
		return net; //the console will print the result
					//that result will be 10

	
Additional examples:

int MyInt = 3
void Start (){
	myInt = AddTwo(myInt);
	Debug.Log (myInt);
		}
int AddTwo(int number){
	int ret;
	ret = number + 2
	return net; //the result is 5
}
	}
}
*/