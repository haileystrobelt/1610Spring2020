using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public Rigidbody rigbod;
    public float myforce = 2000f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() //used FixedUpdate for physic functions
    { 
        rigbod.AddForce(0, 0, myforce * Time.deltaTime); //adding Time.deltaTime will even out FPS advantages on differing computers

        if (Input.GetKey("d")) //if d is pressed...
        {
            rigbod.AddForce(500 * Time.deltaTime, 0, 0); //move object 500 to the right (along x axis)
        }
        
        {
            rigbod.AddForce(-500 * Time.deltaTime, 0, 0); //move object 500 to the left (along x axis)
        }
        
    }
    
    
}


//tutorial from https://www.youtube.com/watch?v=9ZEu_I-ido4 from Brackeys