﻿using UnityEngine;
using UnityEngine.Events;

public class Newer : MonoBehaviour
{

    public float floatNumber;
    public int scoreValue;
    public UnityEvent uEvent;
    
    void Start()
    {
        uEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        print((floatNumber));
    }
}