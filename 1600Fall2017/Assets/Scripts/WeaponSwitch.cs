using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Syntax is the grammar of scripting
public class WeaponSwitch : MonoBehaviour {

	public string[] weapons;
	//Each line must end with a semicolon
	//Open brackets must always be closed
	
	public void MyWeaponSwitch (int i){
		switch (weapons[i])
		{
			case "Missile":
				print("Missile");
				break;
				//Identifiers must always be capitalized

			case "Plasma":
				print("Plasma");
				break;

			default:
				print("You have no other weapons.");
				break;
		}
	}
}
