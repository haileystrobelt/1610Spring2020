﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClass : MonoBehaviour
{
    public string nameString;
    public int intNum;
    public float floatNum;
    public GameObject gameObj;
        
    
    // Start is called before the first frame update
    void Start()
    {
        print(nameString);
        print(intNum);
        print(floatNum);
        print(gameObj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
