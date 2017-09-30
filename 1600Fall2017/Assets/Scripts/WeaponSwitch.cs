using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour {
	public string[] weapons;
	public void MyWeaponSwitch (int i){
		switch (weapons[i])
		{
			case "Missile":
				print("Missile");
				break;
			case "Plasma":
				print("Plasma");
				break;

			/* Switches are used to compare a single variable to a series of constants.
			
			As an example of more switches:
				public int charisma = 3;

				void Greet ()
				{
					switch (charisma)
					{
					case 3:
						print ("Let me take you back to my place.")'
						break;
					case 2:
						print ("You're kinda cute.");
						break;
					case 1:
						print ("Go away.")
						break;
					default:
						print ("Insufficient Charisma level.")
						break;
					}
				}
			*/
			default:
				print("You have no other weapons.");
				break;
		}
	}
}