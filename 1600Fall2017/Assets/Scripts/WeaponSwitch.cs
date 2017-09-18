using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour {

	public string[] weapons;
	
	public void Start (){
		switch (weapons[0])
		{
			case "Missile":
				print("Missile");
				break;

			case "Plasma":
				print("Plasma");
				break;
		}
	}
}
