using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Levelup : MonoBehaviour
{
    public string Name = "Alfred Level"; // Here we make a placeholder for our caracters name
    public int Level = 1; // here we set the starting value for our level so it equals 1 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Calling(Name, Level)); // We call the method "Calling"
    }

    // Update is called once per frame
    void Update()
    {

    }
    private int Calling (string name, int lvl ) // here we create a method called calling which is used to hold our name and current level
    {
        Debug.Log(name);
        Debug.Log (lvl);
        lvl++; // this is used to add levels
        return lvl; // here we loop around to update the level


    }
}
