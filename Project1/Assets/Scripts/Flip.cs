using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public KeyCode key1 =KeyCode.LeftArrow, key2 = KeyCode.RightArrow;
    public float direction1 = 0, direction2 = 180;
   
 
    void Update()
    {
        if (Input.GetKeyDown((KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.identity;
        }

        if (Input.GetKeyDown((KeyCode.RightArrow)
        {
            transform.rotation = Quaternion.Euler(x: 0, y: 180, z:0);
        }
    }

    public void FlipRotate(float value)
    {
        transform.Rotate(xAngle:0, yAngle:value, zAngle:0);   
    }
}
