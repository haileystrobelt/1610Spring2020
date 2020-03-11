using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}


//Used tutorial from Unity's Youtube; https://www.youtube.com/watch?v=Z0Z7xc18CcA&list=PLX2vGYjWbI0S9-X2Q021GUtolTqbUBB9B&index=2&t=0s
