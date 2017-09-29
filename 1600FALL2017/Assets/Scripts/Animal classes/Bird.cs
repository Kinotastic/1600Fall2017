using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class Bird : Animal { 
 
    public void Start() { 
        base.Start(); 
        Fly(); 
    } 
    void Fly () { 
        print(this.name + " Flies"); 
    } 
 
} 