using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classes group together certain variables hierarchically 
//Classes inherit from eachother

public class Animal : MonoBehaviour {
    public void Eat () { 
        print(this.name + " Eats");
	}
	public void Sleep () { 
		print(this.name + " Sleeps");
    }   
    public void Start() {
        Eat();
		Sleep();

    }
}
