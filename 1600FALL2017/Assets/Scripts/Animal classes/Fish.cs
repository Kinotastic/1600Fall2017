using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class Fish : Animal { 
    public void Swim () { 
        print(this.name + " Swims"); 
    }   
    public void Start() { 
        base.Start(); 
        Swim(); 
    }
}